$ ->
  $("a.arm").hover(
    (->
      option_number = $(this).attr("id")[3..4]
      space_id = "div#rin#{option_number}"
      $(space_id).animate { "height": "0px" }
    ), (->
      option_number = $(this).attr("id")[3..4]
      space_id = "div#rin#{option_number}"
      $(space_id).animate { "height": "100px" }
    ))
