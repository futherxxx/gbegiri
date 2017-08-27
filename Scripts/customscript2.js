//cart-js -->

w3ls.render();

w3ls.cart.on('w3sb_checkout', function (evt) {
    var items, len, i;

    if (this.subtotal() > 0) {
        items = this.items();

        for (i = 0, len = items.length; i < len; i++) {
        }
    }
});

 //cart-js -->
