/* Task Description */
/* 
 Create a module for working with books
 The module must provide the following functionalities:
 *	    Add a new book to category
 *	    Each book has unique title, author and ISBN
 *	    It must return the newly created book with assigned ID
 *	    If the category is missing, it must be automatically created
 *	    List all books
 *	    Books are sorted by ID
 *	    This can be done by author, by category or all
 *	    List all categories
 *	    Categories are sorted by ID
 *	    Each book/category has a unique identifier (ID) that is a number greater than or equal to 1
 *	    When adding a book/category, the ID is generated automatically
 *	    Add validation everywhere, where possible
 *	    Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
 *	    Author is any non-empty string
 *	    Unique params are Book title and Book ISBN
 *	    Book ISBN is an unique code that contains either 10 or 13 digits
 *	    If something is not valid - throw Error
 */
function solve() {


    var library = (function () {
        var books = [];
        var categories = [];

        function checkBookParameters(book) {
            if (!book.title || !book.author || !book.isbn || !book.category) {
                throw new Error('Not all book details provided!');
            }

            if (book.title.length < 2 || book.title.length > 100) {
                throw new Error('Invalid book title length!');
            }

            if (book.category.length < 2 || book.category.length > 100) {
                throw new Error('Invalid book category length!');
            }

            if ((book.isbn.length !== 10 && book.isbn.length !== 13) ||
                    //check if isbn is only from digits
                !(/^\d+$/.test(book.isbn.length))) {
                throw new Error('Invalid book isbn!')
            }

            if (typeof book.author !== 'string' || book.author === '') {
                throw new Error('Invalid book author!');
            }

            for (var ind = 0, len = books.length; ind < len; ind += 1) {
                if (books[ind].title === book.title) {
                    throw new Error('A book with that title already exists');
                }
                if (books[ind].isbn === book.isbn) {
                    throw new Error('A book with that isbn already exists');
                }
            }
        }

        function listBooks(searchBy) {
            var booksToList;

            if (arguments.length > 0) {
                if (typeof searchBy.category !== 'undefined') {

                    if(typeof categories[searchBy.category] !== 'undefined'){
                        return categories[searchBy.category].books;
                    }
                    else{
                        return [];
                    }
                }

                if (typeof searchBy.author !== 'undefined') {
                    booksToList = [];

                    for (var ind = 0, len = books.length; ind < len; ind += 1) {
                        if (books[ind].author === searchBy.author) {
                            booksToList.push(books[ind]);
                        }
                    }

                    return booksToList;
                }
            }

            return books.slice();
        }

        function addBook(book) {
            book.ID = books.length + 1;

            checkBookParameters(book);

            // if the category of the book is not in the categories list, create such category with no books
            if (categories.indexOf(book.category) < 0) {
                categories[book.category] = ({
                    ID: categories.length + 1,
                    books: []
                });
            }

            books.push(book);
            categories[book.category].books.push(book);

            return book;
        }

        function listCategories() {
            var categoriesNames = [];
            Array.prototype.push.apply(categoriesNames, Object.keys(categories));

            return categoriesNames;
        }

        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());

    return library;
}

module.exports = solve;