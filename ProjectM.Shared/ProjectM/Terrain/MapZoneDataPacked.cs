// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneDataPacked
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapZoneDataPacked
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_LengthBits;
    private static readonly System.IntPtr NativeFieldInfoPtr_Bytes;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxPackSizeBytes_Public_Static_get_Int32_0;
    [FieldOffset(0)]
    public int LengthBits;
    [FieldOffset(4)]
    public FixedList4096<byte> Bytes;

    public static unsafe int MaxPackSizeBytes
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 766638, RefRangeEnd = 766639, XrefRangeStart = 766635, XrefRangeEnd = 766638, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneDataPacked.NativeMethodInfoPtr_get_MaxPackSizeBytes_Public_Static_get_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static MapZoneDataPacked()
    {
      Il2CppClassPointerStore<MapZoneDataPacked>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (MapZoneDataPacked));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneDataPacked>.NativeClassPtr);
      MapZoneDataPacked.NativeFieldInfoPtr_LengthBits = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDataPacked>.NativeClassPtr, nameof (LengthBits));
      MapZoneDataPacked.NativeFieldInfoPtr_Bytes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneDataPacked>.NativeClassPtr, nameof (Bytes));
      MapZoneDataPacked.NativeMethodInfoPtr_get_MaxPackSizeBytes_Public_Static_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneDataPacked>.NativeClassPtr, 100667781);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneDataPacked>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
