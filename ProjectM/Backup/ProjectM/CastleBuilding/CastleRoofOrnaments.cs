// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleBuilding.CastleRoofOrnaments
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.CastleBuilding
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleRoofOrnaments
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WestOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_EastOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_NorthOrnament;
    private static readonly System.IntPtr NativeFieldInfoPtr_SouthOrnament;
    [FieldOffset(0)]
    public NetworkedEntity WestOrnament;
    [FieldOffset(12)]
    public NetworkedEntity EastOrnament;
    [FieldOffset(24)]
    public NetworkedEntity NorthOrnament;
    [FieldOffset(36)]
    public NetworkedEntity SouthOrnament;

    static CastleRoofOrnaments()
    {
      Il2CppClassPointerStore<CastleRoofOrnaments>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.CastleBuilding", nameof (CastleRoofOrnaments));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleRoofOrnaments>.NativeClassPtr);
      CastleRoofOrnaments.NativeFieldInfoPtr_WestOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoofOrnaments>.NativeClassPtr, nameof (WestOrnament));
      CastleRoofOrnaments.NativeFieldInfoPtr_EastOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoofOrnaments>.NativeClassPtr, nameof (EastOrnament));
      CastleRoofOrnaments.NativeFieldInfoPtr_NorthOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoofOrnaments>.NativeClassPtr, nameof (NorthOrnament));
      CastleRoofOrnaments.NativeFieldInfoPtr_SouthOrnament = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleRoofOrnaments>.NativeClassPtr, nameof (SouthOrnament));
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleRoofOrnaments>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
