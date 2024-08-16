Better aproach of previous example where constructor is hidden then a static factory method creates an instance of Foo to intialize it fluently. 

Foo: Starts with a simple synchronous initialization, than the Async comes right next, updating set values before.

Since the constructor is protected, 'CreateAsync' calls the method and the 'GetIdFromServiceAsync' simulate an async service call.
