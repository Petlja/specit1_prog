import pygame as pg
FONT_NORMAL, FONT_CODE = -1, -2

def unpack_title(s):
    result = []
    prev = 0
    pos1 = s.find('$', prev)
    pos2 = s.find('$', pos1 + 1)
    while  0 <= pos1 and 0 <= pos2:
        if pos1 > prev:
            result.append((s[prev : pos1], FONT_NORMAL))
        result.append((s[pos1+1 : pos2], FONT_CODE))
        prev = pos2+1
        pos1 = s.find('$', prev)
        pos2 = s.find('$', pos1 + 1)
        
    if prev < len(s):
        result.append((s[prev:], FONT_NORMAL))
    return result


def show_subtitles(scenario, subtitles):
    n_img = len(subtitles)
    pg.init()
    images = []
    for i in range(1, n_img+1):
        str_i = str(i)
        str_i = '0' * (3-len(str_i)) + str_i # leading zeros
        in_path = scenario + '_' + str_i + '.png'
        # in_path = f'{image_name_prefix}_{i:03d}.png'
        img = pg.image.load(in_path)
        w, h = int(img.get_width() * 0.66), int(img.get_height() * 0.66)
        img = pg.transform.scale(img, (w, h))
        images.append(img)

    display_width = images[0].get_width()
    display_height = images[0].get_height() + 40
    display = pg.display.set_mode((display_width, display_height))
    pg.display.set_caption(u'Извршавање програма')

    normal_font = pg.font.SysFont("Arial", 20)
    code_font = pg.font.SysFont("Courier New", 20)

    i_img = 0
    done = False
    while not(done):
        display.fill(pg.Color('black'))
        display.blit(images[i_img], (0, 0))
        cnt_image = normal_font.render(str(i_img+1) + '  ', True, pg.Color('orange'))
        text_x = display_width - cnt_image.get_width()
        text_y = display_height - 20 - cnt_image.get_height()//2
        display.blit(cnt_image, (text_x, text_y))
        
        # render subtitle
        text_images = []
        for text, style in unpack_title(subtitles[i_img]):
            if style == FONT_NORMAL:
                text_images.append(normal_font.render(text, True, pg.Color('yellow')))
            else:
                text_images.append(code_font.render(text, True, pg.Color('yellow')))
        if len(text_images) > 0:
            text_width = sum((text_image.get_width() for text_image in text_images))
            text_height = max((text_image.get_height() for text_image in text_images))
            text_x = (display_width - text_width) // 2
            text_y = display_height - 20 - text_height//2
            for text_image in text_images:
                display.blit(text_image, (text_x, text_y))
                text_x += text_image.get_width()

        pg.display.update()
        e = pg.event.wait()
        if e.type == pg.QUIT:
            done = True
        elif e.type == pg.KEYDOWN:
            if e.key == pg.K_q or e.key == pg.K_ESCAPE:
                done = True
            elif e.key == pg.K_LEFT:
                if i_img > 0:
                    i_img -= 1
            elif e.key == pg.K_RIGHT:
                if i_img + 1 < n_img:
                    i_img += 1
            
    pg.quit()

scenario = '41b_fun_niz_po_ref'

subtitles = []
subtitles.append(u'Алоцирамо простор за низ, иницијализујемо га и додељујемо низу $a$.')    # 1
subtitles.append(u'И овако иницијализован низ се такође налази у динамичкој меморији.')     # 2
subtitles.append(u'Функцији $f1$ ћемо проследити копију референце $a$.')                    # 3
subtitles.append(u'Референца $x$ може да промени вредност (да указује на други низ),')      # 4
subtitles.append(u'али то не утиче на низ $a$ у функцији $Main$.')                          # 5
subtitles.append(u'Низ $a$ се није променио, а низ алоциран у функцији је изгубљен.')       # 6
subtitles.append(u'Сада ћемо функцији $f2$ проследити референцу на референцу $a$.')         # 7
subtitles.append(u'Овај пут, $x$ је само друго име за $a$, па мењањем $x$ мењамо и $a$.')   # 8
subtitles.append(u'Сада $a$ користи нову меморију, а претходна меморија је изгубљена.')     # 9
subtitles.append(u'Изгубљену меморију у неком тренутку почисти ђубретарац.')                # 10

show_subtitles(scenario, subtitles)