module Jekyll
  module RelativeSrcFilter
    def relative_src_filter(input, url)
      url = url.strip
      base = Pathname.new(url).dirname.to_s()
      input.gsub(/(src|href)="([^"]*)"/) { |s|
        path = $2
        if !path.start_with? '/', 'http://', 'https://' then
          s.gsub(path, base + '/' + path)
        else
          s
        end
      }
    end
  end
end

Liquid::Template.register_filter(Jekyll::RelativeSrcFilter)
