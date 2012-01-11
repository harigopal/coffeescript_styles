$ ->
  $("a.arsm").hover(
    (->
      option_number = $(this).attr("id")[4..5]
      #space_id = "div#rsin#{option_number}"
      #$(space_id).animate { "height": "0px" }
      for id in [1..5]
        do (id) ->
          space_id = "div#rsin#{id}"
          height = 100 - Math.round(100 / (Math.pow(2, (Math.abs(option_number - id)))))
          $(space_id).stop().animate { "height": "#{height}px" }
    ), (->))
  $("ul#rs").hover(null,
    (->
      for id in [1..5]
        do (id) ->
          space_id = "div#rsin#{id}"
          $(space_id).stop().animate { "height": "100px" }
    )
  )