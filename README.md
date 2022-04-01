# HometasksCsOOPPolymorphism

Tapşırıq:

Product class
 - Name
 - Price
 - GetInfo()

Book class
 - Author
 - Genre
 - GetInfo()


Journal class
 - Company
 -  GetInfo()

Library class
 - Products - Product array
 - AddProduct() - parametr oalraq product dəyəri qəbul edib array-ə add edir
 - GetProductsByPrice() - parametr olaraq minPrice və maxPrice dəyərləri qəbul edib o qiymət aralığındakı məhsulları geri qaytarır array şəklində
 - GetProductByName - parametr olaraq string dəyər qəbul edir və adında həmin dəyər olan məhsullardan ibarət array qaytarır

Journal və Book classları Productdan miras alır
Product abstractdır
Hər bir productın  GetInfo() metodu olmalıdır amma hansı productda nə iş görəcəyi bəlli deyil, Bookda başqa Journal-da başqa əməliyyat gedə bilər


Program cs-də Library obyekti düzəldib içinə productları add edirsiniz
Daha sonra consoledan dəyərlər qəbul edib o dəyərlərə əsasən GetProductsByPrice və GetProductByName  metodlarını işlədirsiniz. O metodlar array qaytarır və o array-ləri döngüyə salıb GetInfo metodlarından qayıdan string dəyəri console-a yazdırırsınız.

Classwork-Task-Link:https://github.com/Sunaljabili/BP202-Abstract-Interface
