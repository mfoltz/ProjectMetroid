// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.LabelOverrides
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using Stunlock.Localization;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct LabelOverrides
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Label1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label1Key;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label2Key;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label1AlwaysShow;
    private static readonly System.IntPtr NativeFieldInfoPtr_Label2AlwaysShow;
    [FieldOffset(0)]
    public FixedString64 Label1;
    [FieldOffset(64)]
    public LocalizationKey Label1Key;
    [FieldOffset(80)]
    public LocalizationKey Label2Key;
    [FieldOffset(96)]
    public bool Label1AlwaysShow;
    [FieldOffset(97)]
    public bool Label2AlwaysShow;

    static LabelOverrides()
    {
      Il2CppClassPointerStore<LabelOverrides>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (LabelOverrides));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<LabelOverrides>.NativeClassPtr);
      LabelOverrides.NativeFieldInfoPtr_Label1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelOverrides>.NativeClassPtr, nameof (Label1));
      LabelOverrides.NativeFieldInfoPtr_Label1Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelOverrides>.NativeClassPtr, nameof (Label1Key));
      LabelOverrides.NativeFieldInfoPtr_Label2Key = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelOverrides>.NativeClassPtr, nameof (Label2Key));
      LabelOverrides.NativeFieldInfoPtr_Label1AlwaysShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelOverrides>.NativeClassPtr, nameof (Label1AlwaysShow));
      LabelOverrides.NativeFieldInfoPtr_Label2AlwaysShow = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<LabelOverrides>.NativeClassPtr, nameof (Label2AlwaysShow));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<LabelOverrides>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
