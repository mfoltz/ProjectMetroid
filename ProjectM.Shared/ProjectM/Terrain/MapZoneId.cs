// Decompiled with JetBrains decompiler
// Type: ProjectM.Terrain.MapZoneId
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Terrain
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MapZoneId
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkCoordinate;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneId;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Empty_Public_Static_get_MapZoneId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ZoneIndex_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ZoneIndex_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MapZoneId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MapZoneId_MapZoneId_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MapZoneId_MapZoneId_0;
    [FieldOffset(0)]
    public TerrainChunk ChunkCoordinate;
    [FieldOffset(8)]
    public byte ZoneId;

    public static unsafe MapZoneId Empty
    {
      [CallerCount(18), CachedScanResults(RefRangeStart = 363406, RefRangeEnd = 363424, XrefRangeStart = 363406, XrefRangeEnd = 363424, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneId.NativeMethodInfoPtr_get_Empty_Public_Static_get_MapZoneId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(MapZoneId*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public unsafe int ZoneIndex
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 766612, RefRangeEnd = 766615, XrefRangeStart = 766612, XrefRangeEnd = 766612, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneId.NativeMethodInfoPtr_get_ZoneIndex_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(2), CachedScanResults(RefRangeStart = 766615, RefRangeEnd = 766617, XrefRangeStart = 766615, XrefRangeEnd = 766615, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(MapZoneId.NativeMethodInfoPtr_set_ZoneIndex_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 766618, RefRangeEnd = 766628, XrefRangeStart = 766617, XrefRangeEnd = 766618, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(MapZoneId other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MapZoneId_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 766630, RefRangeEnd = 766631, XrefRangeStart = 766628, XrefRangeEnd = 766630, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766631, XrefRangeEnd = 766634, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 766634, XrefRangeEnd = 766635, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(MapZoneId obj1, MapZoneId obj2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &obj1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &obj2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MapZoneId_MapZoneId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(10)]
    [CachedScanResults(RefRangeStart = 766618, RefRangeEnd = 766628, XrefRangeStart = 766618, XrefRangeEnd = 766628, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(MapZoneId obj1, MapZoneId obj2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &obj1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &obj2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MapZoneId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MapZoneId_MapZoneId_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static MapZoneId()
    {
      Il2CppClassPointerStore<MapZoneId>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Terrain", nameof (MapZoneId));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr);
      MapZoneId.NativeFieldInfoPtr_ChunkCoordinate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, nameof (ChunkCoordinate));
      MapZoneId.NativeFieldInfoPtr_ZoneId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, nameof (ZoneId));
      MapZoneId.NativeMethodInfoPtr_get_Empty_Public_Static_get_MapZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, 100667773);
      MapZoneId.NativeMethodInfoPtr_get_ZoneIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, 100667774);
      MapZoneId.NativeMethodInfoPtr_set_ZoneIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, 100667775);
      MapZoneId.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_MapZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, 100667776);
      MapZoneId.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, 100667777);
      MapZoneId.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, 100667778);
      MapZoneId.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_MapZoneId_MapZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, 100667779);
      MapZoneId.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_MapZoneId_MapZoneId_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, 100667780);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MapZoneId>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
