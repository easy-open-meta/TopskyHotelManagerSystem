(function ($) {
"use strict";
/*--
	Counter UP
-----------------------------------*/
$('.counter').counterUp({
    delay: 20,
    time: 3000
});
/*--
	Menu Sticky
-----------------------------------*/
$(window).on('scroll', function() {
	var scroll = $(window).scrollTop();
    var sticky = $('.header-bottom');
	if (scroll < 400) {
		sticky.removeClass('stick');
	}else{
		sticky.addClass('stick');
	}
});
/*--
	Search Toggle
-----------------------------------*/
$('.search-toggle').on('click', function(){
    $('.header-search-form').toggleClass('active');
})
/*--
	One Page Menu
-----------------------------------*/
var TopOffsetId = $('.header-bottom').height() - -19;
$('.onepage-nav nav').onePageNav({
    currentClass: 'active',
    scrollThreshold: 0.2,
    scrollSpeed: 1000,
    scrollOffset: TopOffsetId,
});
/*--
	Bootstrap Menu Fix For Mobile
-----------------------------------*/
$(document).on('click','.navbar-collapse.in',function(e) {
    if( $(e.target).is('a') ) {
        $(this).collapse('hide');
    }
});
/*--
	Hero Slider
-----------------------------------*/
$('.hero-slider').slick({
    arrows: false,
    infinite: true,
    slidesToShow: 1,
    dots: true,
    fade: true,
    customPaging : function(slider, i) {
        var thumb = $(slider.$slides[i]).data('thumb');
        return '<button class="overlay"><img src="'+thumb+'"></button>';
    },
    responsive: [
        {
          breakpoint: 600,
          settings: {
              dots: false,
              autoplay: true,
              autoplaySpeed: 5000,
          }
        }
    ]
});
/*--
	Amenities Border Line
-----------------------------------*/
$('.amenities-content ul li').each(function(){

    var aLBorder = $(this).find('.left').width();
    var aRBorder = $(this).find('.right').width();

    $(this).find('.border').css({
        left: (aLBorder + 10),
        right: (aRBorder + 10),
    })
}) 
/*--
	Testimonial Slider
-----------------------------------*/
$('.testimonial-slider').slick({
    arrows: false,
    infinite: true,
    slidesToShow: 1,
});
/*--
	Blog Slider
-----------------------------------*/
$('.blog-slider').slick({
    arrows: false,
    infinite: true,
    slidesToShow: 3,
    responsive: [
        {
          breakpoint: 950,
          settings: {
              slidesToShow: 2,
          }
        },
        {
          breakpoint: 750,
          settings: {
              slidesToShow: 1,
          }
        }
    ]
});
/*--
	Magnific Popup
-----------------------------------*/
/*-- Video --*/
$('.video-popup').magnificPopup({
	type: 'iframe',
	mainClass: 'mfp-fade',
	removalDelay: 160,
	preloader: false,
	zoom: {
		enabled: true,
	}
});
/*-- Image --*/
$('.image-popup').magnificPopup({
	type: 'image',
});
/*-- Gallery --*/
$('.gallery-popup').magnificPopup({
	type: 'image',
	gallery:{
		enabled:true
	}	
});
/*-- Video Gallery --*/
$('.video-gallery-popup').magnificPopup({
	type: 'iframe',
	mainClass: 'mfp-fade',
	removalDelay: 160,
	preloader: false,
	zoom: {
		enabled: true,
	},
	gallery:{
		enabled:true
	}	
});
/*--
	Smooth Scroll
-----------------------------------*/
$('[data-scroll]').on('click', function(e) {
	e.preventDefault();
	var link = this;
	$.smoothScroll({
        speed: 1000,
        scrollTarget: link.hash,
        offset: -90,
	});
});
/*--
	Scroll Up
-----------------------------------*/
$.scrollUp({
	easingType: 'linear',
	scrollSpeed: 900,
	animation: 'fade',
	scrollText: '<i class="zmdi zmdi-chevron-up"></i>',
});
 

})(jQuery);	