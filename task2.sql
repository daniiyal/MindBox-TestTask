
SELECT p.product_name, c.category_name
FROM Products p
LEFT JOIN ProductsCategories pc ON p.id = pc.product_id
LEFT JOIN Categories c on c.id = pc.category_id
