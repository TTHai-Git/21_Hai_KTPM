import json
import os
from flask import Flask, jsonify, request

# Sử dụng thư viện flask để tạo api

app = Flask(__name__)

# load danh sách sản phẩm từ file json chứa dữ liệu mô phỏng
path = 'test/testdata/product/product-data-21-Hai.json'
with open(path, 'r', encoding='utf-8') as file:
    products = json.load(file)


# Tạo api tìm kiếm sản phẩm theo từ khóa
@app.route('/api/search', methods=['GET'])
def search_by_name_of_product_21_Hai():
    keyword = request.args.get('name', '')
    if not keyword:
        return jsonify({"message_error": "Tên không được bỏ trống"}), 400
    results = [product for product in products if keyword.lower() in product['name'].lower()]
    return jsonify({"results": results})


# Tạo api sắp xếp sản phẩm theo giá tăng dần
@app.route('/api/sort-asc', methods=['GET'])
def sort_by_price_asc_21_Hai():
    sorted_products = sorted(products, key=lambda x: x['price'])
    return jsonify({"results": sorted_products})


# Tạo api tìm kiếm sản phẩm trong khoảng giá min tới max
@app.route('/api/search/price', methods=['GET'])
def search_by_price_21_Hai():
    min_price = request.args.get('min', None)
    max_price = request.args.get('max', None)

    try:
        min_price = float(min_price)
        max_price = float(max_price)
    except ValueError:
        return jsonify({"message_error": "Tham số giá không hợp lệ"}), 400
    if min_price > max_price:
        return jsonify(
            {"message_error": "Khoảng giá không hợp lệ!!! Vui lòng nhập giá Min price nhỏ hơn giá Max price"}), 400
    results = [product for product in products if min_price <= product['price'] <= max_price]
    return jsonify({"results": results})


@app.route('/api/update/<int:idx>/price', methods=['GET', 'PATCH'])
def update_price_of_product_21_Hai(idx):
    update_price = request.args.get('update_price')
    path = 'test/testdata/product/product-data-21-Hai.json'

    try:
        update_price = float(update_price)

        with open(path, 'r', encoding='utf-8') as file:
            products = json.load(file)

        if idx < 0 or idx >= len(products):
            return jsonify({"message_error": "Không tìm thấy sản phẩm cần cập nhật giá"}), 400

        if update_price < 0:
            return jsonify({"message_error": "Tham số giá không hợp lệ"}), 400

        products[idx]['price'] = update_price

        with open(path, 'w', encoding='utf-8') as file:
            json.dump(products, file, ensure_ascii=False, indent=4)

        return jsonify({"result": products[idx]}), 200

    except FileNotFoundError:
        return jsonify({"message_error": "Không tìm thấy tệp JSON"}), 400
    except ValueError:
        return jsonify({"message_error": "Tham số giá không hợp lệ"}), 400


@app.route('/api/add/product', methods=['GET', 'POST'])
def add_product_21_Hai():
    name = request.args.get('name', '')
    price = request.args.get('price', None)
    path = 'test/testdata/product/product-data-21-Hai.json'
    try:
        if os.path.exists(path):
            with open(path, 'r', encoding='utf-8') as file:
                products = json.load(file)
        else:
            products = []

        for product in products:
            if product['name'].__eq__(name):
                return jsonify({"message_error": "Thêm sản phẩm thất bại!!! "
                                                 "Sản phẩm đã tồn tại"}), 400

        price = float(price)

        if not name:
            return jsonify({
                "message_error": "Thêm sản phẩm thất bại!!! "
                                 "Thiếu tham số tên (name) của sản phẩm"}), 400
        elif price < 0:
            return jsonify({"message_error": "Thêm sản phẩm thất bại!!! "
                                             "Tham số giá (price) của sản phẩm không hợp lệ"}), 400

        products.append({"name": name, "price": price})

        with open(path, 'w', encoding='utf-8') as file:
            json.dump(products, file, ensure_ascii=False, indent=4)

        return jsonify({"result": products[len(products) - 1]}), 200

    except ValueError:
        return jsonify({"message_error": "Thêm sản phẩm thất bại!!! "
                                         "Tham số giá (price) của sản phẩm không hợp lệ"}), 400
    except Exception:
        return jsonify({"message_error": "Thêm sản phẩm thất bại!!! "
                                         "Thiếu tham số tên (name) và giá (price) của sản phẩm "
                                         "Hoặc là chỉ thiếu tham số giá (price) của sản phẩm"}), 400


@app.route('/api/delete/<int:idx>/product', methods=['DELETE'])
def del_product_21_Hai(idx):
    try:
        with open(path, 'r', encoding='utf-8') as file:
            products = json.load(file)

        del_product = products.pop(idx)

        with open(path, 'w', encoding='utf-8') as file:
            json.dump(products, file, ensure_ascii=False, indent=4)

        print(del_product)

        return jsonify({"success_message": "Sản phẩm đã được xóa thành công!"}), 204

    except IndexError:
        return jsonify({"error_message": "Xóa sản phẩm thất bại!!! "
                                         "Vui lòng kiểm tra lại thứ tự của sản phẩm muốn xóa"}), 400
    except Exception as ex:
        return jsonify({"error_message": str(ex)}), 500


if __name__ == '__main__':
    app.run(debug=True)
