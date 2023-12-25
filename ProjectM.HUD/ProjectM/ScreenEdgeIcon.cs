// Decompiled with JetBrains decompiler
// Type: ProjectM.ScreenEdgeIcon
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct ScreenEdgeIcon
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyShowIfOwner;
    private static readonly System.IntPtr NativeFieldInfoPtr_OnlyShowIfAlly;
    [FieldOffset(0)]
    public PrefabGUID Guid;
    [FieldOffset(4)]
    public bool OnlyShowIfOwner;
    [FieldOffset(5)]
    public bool OnlyShowIfAlly;

    static ScreenEdgeIcon()
    {
      Il2CppClassPointerStore<ScreenEdgeIcon>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM", nameof (ScreenEdgeIcon));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScreenEdgeIcon>.NativeClassPtr);
      ScreenEdgeIcon.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIcon>.NativeClassPtr, nameof (Guid));
      ScreenEdgeIcon.NativeFieldInfoPtr_OnlyShowIfOwner = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIcon>.NativeClassPtr, nameof (OnlyShowIfOwner));
      ScreenEdgeIcon.NativeFieldInfoPtr_OnlyShowIfAlly = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScreenEdgeIcon>.NativeClassPtr, nameof (OnlyShowIfAlly));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScreenEdgeIcon>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
