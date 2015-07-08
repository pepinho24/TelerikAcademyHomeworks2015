// Creating a module a.k.a. IIFE ( brackets (), function, brackets (), brackets {},brackets () )
var module = (function () {
}());

// Creating a module in a function (module pattern)
function solve() {
    var module = (function () {
        // everything in the return will be exposed to the outer world
        return {
            getSomething: function (something) {
                return something;
            },
            getNothing: function () {
            }
        }
    }());

    return module;
}

// Creating a new module ("class"), and in our case some kind of an interface or abstract class
var module = (function () {
    // Create Constants
    var CONSTANTS = {
        NAME_MIN_LENGTH: 2,
        NAME_MAX_LENGTH: 50
    }


    // create validator
    var validator = {
        // this function may not throw exceptions, but for demo purposes it works :)
        isStringValid: function (value, minLen, maxLen, name) {
            name = name || 'Value';
            if (value === undefined) {
                throw new Error(name + ' cannot be undefined!');
            }

            if (typeof value !== 'string') {
                throw new Error(name + ' must be a string!');
            }

            if (value.length < minLen || maxLen < value.length) {
                throw new Error(name + ' must be a between ' + minLen + ' and ' + maxLen + ' characters!');
            }

            return true;
        }
    }

    // Creating the abstract (parent) class
    var animal = (function () {
        // Creating an object "animal"
        var animal = Object.create({}),

        // Creating an unique id for every animal
            currentId = 0;


        // Creating a constructor
        Object.defineProperty(animal, 'init', {
            // creating a getter and setter, when we want to have a validation
            //get: ... ,
            //set: ... ,

            //when we want a function (a.k.a. method) we use value: function(){ ... }

            value: function (name, age) {
                this.name = name;
                this.age = age;
                // this _id should be private
                this._id = ++currentId;

                // "return this" enables chaining (e.g. animal.init(name,age).somethingElse())
                return this;
            }
        });

        // Creating properties
        Object.defineProperty(animal, 'id', {
            // creating only getter, because we don't want to anybody to set a value to "id"
            get: function () {
                return this._id;
            }
        });

        Object.defineProperty(animal, 'name', {
            get: function () {
                return this._name;
            },
            set: function (value) {
                if (!validator.isStringValid(value, CONSTANTS.NAME_MIN_LENGTH, CONSTANTS.NAME_MIN_LENGTH, 'Name')) {
                    throw new Error('Invalid name!');
                }

                this._name = value;
            }
        });

        Object.defineProperty(animal, 'age', {
            get: function () {
                return this._age;
            },
            set: function (value) {
                // converting a string to a number if possible
                value = +value;
                if (typeof value !== 'number' || value < 0) {
                    throw new Error('Invalid age!');
                }

                this._age = value;
            }
        });

        // creating a method for all the animals
        Object.defineProperty(animal, 'breathe', {
            value: function () {
                return this.name + ' is breathing!';
            }
        });

        return animal
    }());

    var human = (function (parent) {
        // this is the inheritance!
        var human = Object.create(parent);

        // Creating a constructor
        Object.defineProperty(human, 'init', {
            value: function (name, age, job) {
                // reusing the parents constructor, so we do not have to rewrite the properties name and age
                parent.init.call(this, name, age);
                this.job = job;

                return this;
            }
        });
        Object.defineProperty(human, 'job', {
            get: function () {
                return this._job;
            },
            set: function (value) {
                if (!validator.isStringValid(value, CONSTANTS.NAME_MIN_LENGTH, CONSTANTS.NAME_MIN_LENGTH, 'Job')) {
                    throw new Error('Invalid job!');
                }

                this._job = value;
            }
        });

        Object.defineProperty(human, 'breathe', {
            value: function () {
                return parent.breathe.call(this) + ' - It is so hot!'
            }
        });

        return human;
    }(animal));// give the class we want the human to inherit

    return {
        getAnimal: function (name, age) {
            return Object.create(animal).init(name, age);
        },
        getHuman: function (name, age, job) {
            return Object.create(human).init(name, age, job);
        }

    }
}());