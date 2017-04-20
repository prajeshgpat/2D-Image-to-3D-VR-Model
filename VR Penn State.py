import numpy as np
import cv2
import math

img = cv2.imread('room.jpg')
imgr = cv2.resize(img,(960,540))
##imgr = cv2.resize(img,(432,648))

gray = cv2.cvtColor(imgr,cv2.COLOR_BGR2GRAY)
edges = cv2.Canny(gray,100,200,apertureSize = 3)

minLineLength = 0
maxLineGap = 0
##Vertical lines
lines1 = cv2.HoughLinesP(edges,100,np.pi,150,minLineLength,maxLineGap)
for a in range(0, len(lines1)):
    for x1,y1,x2,y2 in lines1[a]:
        cv2.line(imgr,(x1,y1),(x2,y2),(0,255,0),2)

##Vertical and Horizontal
lines2 = cv2.HoughLinesP(edges,100,np.pi/2,150,minLineLength,maxLineGap)
for b in range(0, len(lines2)):
    for x3,y3,x4,y4 in lines2[b]:
        cv2.line(imgr,(x3,y3),(x4,y4),(0,255,0),2)

##Oblique
lines3 = cv2.HoughLinesP(edges,100,np.pi/180,150,100,5)
for x in range(0, len(lines3)):
    for x5,y5,x6,y6 in lines3[x]:
        cv2.line(imgr,(x5,y5),(x6,y6),(0,255,0),2)

z=0      
midx = 960/2
midy = 540/2

ans = []
for y in range(0, edges.shape[0]):
    for x in range(0, edges.shape[1]):
        z = ((midx-x)**(2.0)+(midy-y)**(2.0))**(1/2.0)
        if edges[y, x] != 0:
            ans = ans + [[x, y, z]]

np.savetxt('VR_Test_Data', ans, fmt = '%4.0f')

cv2.imshow('HoughLines',imgr)
cv2.waitKey(0)
cv2.destroyAllWindows()
