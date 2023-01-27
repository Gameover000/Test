sql запрос к 3 заданию


select prod.name [Имя продукта], cat.name [Имя категории]
from product prod
left join ProductsCategory prodcat on prod.id = prodcat.products_id
inner join categor cat on cat.id = prodcat.category_id
order by prod.name
