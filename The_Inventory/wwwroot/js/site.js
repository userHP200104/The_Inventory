// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

$(() => {

    $('.reaction_repo').hide();

    $(".first-tab").on("click", function () {

        $(".first-tab").removeClass('active')
        $(this).addClass('active');

        if ($(".active").hasClass('chem')) {
            $('.reaction_repo').hide();
            $('.chemical_repo').show();
            console.log('chem active');

        }

        if ($(".active").hasClass('react')) {
            $('.chemical_repo').hide();
            $('.reaction_repo').show();
            console.log('react active');
        }
    });

    //$(".second-tab").on("click", function () {

    //    $(".second-tab").removeClass('active')
    //    $(this).addClass('active');

    //    if ($(".raw-chemical").hasClass('.active')) {
    //        $('.compound-chemical').hide();
    //        $('.radioactive-chemical').hide();
    //        $('.isotope-chemical').hide();
    //        $('.raw-chemical').show();
    //        console.log('raw-chemical');

    //    }

    //    if ($(".compound-chemical").hasClass('active')) {
    //        $('.raw-chemical').hide();
    //        $('.radioactive-chemical').hide();
    //        $('.isotope-chemical').hide();
    //        $('.compound-chemical').show();
    //        console.log('compound-chemical');

    //    }

    //    if ($(".radioactive-chemical").hasClass('active')) {
    //        $('.raw-chemical').hide();
    //        $('.compound-chemical').hide();
    //        $('.isotope-chemical').hide();
    //        $('.radioactive-chemical').show();
    //        console.log('radioactive-chemical');

    //    }

    //    if ($(".isotope-chemical").hasClass('active')) {
    //        $('.raw-chemical').hide();
    //        $('.compound-chemical').hide();
    //        $('.radioactive-chemical').hide();
    //        $('.isotope-chemical').show();
    //        console.log('isotope-chemical');

    //    }

       
    //});

    //$(".third-tab").on("click", function () {

    //    $(".third-tab").removeClass('active')
    //    $(this).addClass('active');

    //    if ($(".raw-reaction").hasClass('active')) {
    //        $('.compound-reaction').hide();
    //        $('.raw-reaction').show();
    //        console.log('raw-reaction active');

    //    }

    //    if ($(".compound-reaction").hasClass('active')) {
    //        $('.raw-reaction').hide();
    //        $('.compound-reaction').show();
    //        console.log('compound-reaction active');
    //    }
    //});


});