$.fn.likwidcarousel = function( options ) {

    var opts = $.extend( {}, $.fn.likwidcarousel.defaults, options );
    
    this.css("width", opts.w );
    this.css("height", opts.h );
    this.css("background-color", opts.c);
    this.css("display", "inline-block");
       
    console.log(this[0].children.length);
    for( i = 0; i < this[0].children.length; i++) {
      console.log(this[0].children[i]);
      this[0].children[i].width = 10;
      this[0].children[i].height = 10;
      
    }
}

$.fn.likwidcarousel.defaults = {
    w: "100",
    h: "100",
    c: "blue"
};