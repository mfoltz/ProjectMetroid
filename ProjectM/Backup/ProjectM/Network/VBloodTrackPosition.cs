// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.VBloodTrackPosition
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct VBloodTrackPosition
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UnitPrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_X;
    private static readonly System.IntPtr NativeFieldInfoPtr_Z;
    [FieldOffset(0)]
    public PrefabGUID UnitPrefabGuid;
    [FieldOffset(4)]
    public short X;
    [FieldOffset(6)]
    public short Z;

    static VBloodTrackPosition()
    {
      Il2CppClassPointerStore<VBloodTrackPosition>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (VBloodTrackPosition));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<VBloodTrackPosition>.NativeClassPtr);
      VBloodTrackPosition.NativeFieldInfoPtr_UnitPrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackPosition>.NativeClassPtr, nameof (UnitPrefabGuid));
      VBloodTrackPosition.NativeFieldInfoPtr_X = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackPosition>.NativeClassPtr, nameof (X));
      VBloodTrackPosition.NativeFieldInfoPtr_Z = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<VBloodTrackPosition>.NativeClassPtr, nameof (Z));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<VBloodTrackPosition>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
