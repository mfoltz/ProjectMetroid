// Decompiled with JetBrains decompiler
// Type: ProjectM.UI.VBloodPosition
// Assembly: ProjectM.HUD, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 19DF27AB-2445-4ADB-A558-10C99A6E640A
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.HUD.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM.UI
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodPosition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Position;
    [FieldOffset(0)]
    public PrefabGUID UnitPrefabGuid;
    [FieldOffset(4)]
    public float2 Position;

    static VBloodPosition()
    {
      Il2CppClassPointerStore<VBloodPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.HUD.dll", "ProjectM.UI", nameof (VBloodPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodPosition>.NativeClassPtr);
      VBloodPosition.NativeFieldInfoPtr_UnitPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPosition>.NativeClassPtr, nameof (UnitPrefabGuid));
      VBloodPosition.NativeFieldInfoPtr_Position = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodPosition>.NativeClassPtr, nameof (Position));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodPosition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
