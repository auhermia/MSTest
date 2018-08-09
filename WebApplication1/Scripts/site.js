$(document).ready(function () {

    // Add new FOrm Item
    $('#addItem').click(function () {
        //$('.formItem').last().clone().insertBefore($('#addItem'));
        $.ajax({
            url: "/CSVBuilder/NewItemPartialView",
            type: "GET",
            async: false,
            success: function (result) {
                $('#addItem').before(result);
            }
        });

    });

    // load correct content depending on item type
    // bind to parent element to enable use on dynamically added elements
    //$(staticAncestors).on(eventName, dynamicChild, function() {});
    $('.form').on('change', '#typeDropdown', function () {
        if ($('#typeDropdown :selected').text() == "Question") {

        }
    });
});


/*
                '<div id="questionNum">' +
                    '@Html.Hidden("Id")' +
                    '<label for="questionNum">Question Number:</label>'+
                    '<input id="questionNum" type="text" />'+
                '</div>'+
                '<div class="row">'+
                    '<div class="col-md-4">'+
                        '<label for="questionText">Text</label>'+
                        '<textarea id="questionText" cols="20" rows="1"></textarea>'+
                    '</div>'+
                    '<div class="col-md-4">'+
                        '<label for="answerControl">Answer Control:</label>' +
                        '<ul class="dropdown-menu"></ul>'+
                        '<select id="answerControl">'+
                            '<option>Radio button: No, Yes</option>'+
                            '<option>Radio button: No, Yes, N/A</option>'+
                            '<option>Textbox</option>'+
                        '</select>'+
                    '</div>' +
                    '<div class="col-md-4">' +
                        '<label for="subQuestion">Sub-Question?</label>' +
                        '<select id="subQuestion">'+
                            '<option>Yes</option>'+
                            '<option>No</option>'+
                        '</select>'+
                    '</div>'+
                '</div>'



            //$.ajax({
            //    url: "/CSVBuilder/NoteHeaderPartialView",
            //    type: "GET",
            //    success: function (result) {
            //        $('#questionTest').html(result);
            //        alert("note / section header");
            //    }
            //});

            //$('#questionTest').html(

            //);

            // load correct partial view ...tedious
            //$.ajax({
            //    url: "/CSVBuilder/QuestionPartialView",
            //    type: "GET",
            //    success: function (result) {
            //        $('#questionTest').html(result);
            //        alert("hey");
            //    }
            //});
        }
*/