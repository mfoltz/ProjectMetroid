// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodPassiveData
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodPassiveData
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Description;
    private static readonly System.IntPtr NativeFieldInfoPtr_Name;
    [FieldOffset(0)]
    public LocalizedStringBuilderBase Description;
    [FieldOffset(24)]
    public LocalizationKey Name;

    static VBloodPassiveData()
    {
      Il2CppClassPointerStore<VBloodPassiveData>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.UI", nameof (VBloodPassiveData));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodPassiveData>.NativeClassPtr);
      VBloodPassiveData.NativeFieldInfoPtr_Description = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPassiveData>.NativeClassPtr, nameof (Description));
      VBloodPassiveData.NativeFieldInfoPtr_Name = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPassiveData>.NativeClassPtr, nameof (Name));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodPassiveData>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
