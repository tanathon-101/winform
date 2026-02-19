# MyFormApp

โปรเจคตัวอย่าง .NET MAUI (MyFormApp)

## คำอธิบาย
แอปนี้เป็นโปรเจค .NET MAUI ที่สามารถรันบนหลายแพลตฟอร์ม รวมถึง Mac Catalyst

## ความต้องการ (Prerequisites)
- macOS ที่รองรับการพัฒนา Mac Catalyst
- ติดตั้ง .NET SDK 10 (หรือเวอร์ชันที่ใช้ในโปรเจค)

ตรวจสอบเวอร์ชัน .NET ด้วยคำสั่ง:

```
dotnet --version
```

## วิธีรัน (Run)
รันแอปสำหรับ Mac Catalyst ด้วยคำสั่ง:

```
dotnet run -f net10.0-maccatalyst
```

คำสั่งนี้จะบิลด์และเปิดแอปบน Mac Catalyst (หรือ iOS simulator/ตัวจำลองที่เกี่ยวข้อง) ขึ้นอยู่กับการตั้งค่าเครื่องของคุณ

### รันบน Windows
โปรเจคนี้รองรับ Windows (`net10.0-windows10.0.19041.0`) หากต้องการรันบนเครื่อง Windows ให้ใช้คำสั่ง:

```
dotnet run -f net10.0-windows10.0.19041.0
```

หรือเปิด `MyFormApp.sln` ใน Visual Studio (ที่มี MAUI/Windows workload) แล้วเลือก target เป็น Windows แล้วกด Run

## หมายเหตุ
- ถ้าต้องการรันบนแพลตฟอร์มอื่น ให้เปลี่ยน target framework (เช่น `net10.0-android`) หรือใช้ Visual Studio เพื่อเลือก target
- หากเกิดปัญหาเกี่ยวกับ provisioning หรือ signing บน Mac Catalyst ให้ตรวจสอบ `Entitlements.plist` และการตั้งค่า signing ใน Xcode/Visual Studio

## ไฟล์ที่เกี่ยวข้อง
- `MyFormApp.csproj`

---

ถ้าต้องการ ฉันสามารถเพิ่มคำแนะนำการดีพลอยหรือตัวอย่างการบิลด์เพิ่มเติมได้
