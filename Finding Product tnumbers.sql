SELECT Count(p.ProductID) FROM Products p JOIN Categories c
on c.CategoryID = p.CategoryID
Where c.CategoryID = 1;
