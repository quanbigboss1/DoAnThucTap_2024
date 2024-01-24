from flask import Flask, request, jsonify
from sklearn.feature_extraction.text import TfidfVectorizer
from sklearn.ensemble import RandomForestClassifier
from sklearn.metrics.pairwise import cosine_similarity
import pandas as pd


app = Flask(__name__)

# Đường dẫn đầy đủ đến file CSV trên máy tính của bạn
file_path = 'C:\\Users\\hongh\\OneDrive\\Desktop\\Tài liệu học năm 4\\datasets.csv'

# Đọc file CSV và chuyển thành DataFrame
df = pd.read_csv(file_path)

# Chuẩn bị dữ liệu
X = df[['MoTaCongViec', 'YeuCauCongViec', 'DiaDiemLamViec']]  # Thêm 'DiaDiem'
y = df['TenViTri']

# Tiền xử lý văn bản
vectorizer = TfidfVectorizer(stop_words='english')
X_tfidf = vectorizer.fit_transform(X.apply(lambda x: ' '.join(x), axis=1))

# Mô hình hóa - sử dụng RandomForestClassifier làm ví dụ
model = RandomForestClassifier()
model.fit(X_tfidf, y)

@app.route('/predict', methods=['POST'])
def predict():
    data = request.get_json()

    mota_input = data.get('mota')
    yeucau_input = data.get('yeucau')
    location_input = data.get('location')

    # Tiền xử lý văn bản cho mô tả công việc mới
    new_job_description = ' '.join([mota_input, yeucau_input, location_input])
    new_job_tfidf = vectorizer.transform([new_job_description])

    # Dự đoán tất cả các công việc
    all_jobs_tfidf = X_tfidf
    all_predicted_jobs = model.predict(all_jobs_tfidf)

    # Tính độ tương đồng cosine giữa công việc mới và tất cả các công việc
    similarity_scores = cosine_similarity(new_job_tfidf, all_jobs_tfidf)[0]

    # Sắp xếp và chọn ra 10 công việc có độ tương đồng cao nhất
    top_10_indices = similarity_scores.argsort()[-10:][::-1]
    top_10_jobs = all_predicted_jobs[top_10_indices]
    top_10_similarity_scores = similarity_scores[top_10_indices]

    # Lưu kết quả vào một từ điển
    result = {
        "top_10_jobs": top_10_jobs.tolist()
        #"top_10_similarity_scores": top_10_similarity_scores.tolist()
    }

    return jsonify(result), 200, {'Content-Type': 'application/json; charset=utf-8'}

if __name__ == "__main__":
    app.run(debug=True)
    
