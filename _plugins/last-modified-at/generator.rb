# From: https://github.com/CarlosBonetti/jekyll-last-modified-at
# Original in: https://github.com/gjtorikian/jekyll-last-modified-at

module Jekyll
  module LastModifiedAt
    class Generator < Jekyll::Generator

      def generate(site)
        site.each_site_file { |item|
          item.data['last_modified_at'] = Determinator.new(site.source, item.path) if item.respond_to?(:data)
        }
      end

    end
  end
end
