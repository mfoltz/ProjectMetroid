// Decompiled with JetBrains decompiler
// Type: ProjectM.WorldZoneCollectionQueries
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct WorldZoneCollectionQueries
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_ChunkMetadataQuery;
    private static readonly System.IntPtr NativeFieldInfoPtr_ZoneQuery;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_WorldZoneCollectionQueries_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public EntityQuery ChunkMetadataQuery;
    [FieldOffset(16)]
    public EntityQuery ZoneQuery;

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1049452, RefRangeEnd = 1049455, XrefRangeStart = 1049439, XrefRangeEnd = 1049452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe WorldZoneCollectionQueries Create(EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WorldZoneCollectionQueries.NativeMethodInfoPtr_Create_Public_Static_WorldZoneCollectionQueries_EntityManager_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(WorldZoneCollectionQueries*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1049457, RefRangeEnd = 1049460, XrefRangeStart = 1049455, XrefRangeEnd = 1049457, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(WorldZoneCollectionQueries.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static WorldZoneCollectionQueries()
    {
      Il2CppClassPointerStore<WorldZoneCollectionQueries>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WorldZoneCollectionQueries));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WorldZoneCollectionQueries>.NativeClassPtr);
      WorldZoneCollectionQueries.NativeFieldInfoPtr_ChunkMetadataQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldZoneCollectionQueries>.NativeClassPtr, nameof (ChunkMetadataQuery));
      WorldZoneCollectionQueries.NativeFieldInfoPtr_ZoneQuery = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WorldZoneCollectionQueries>.NativeClassPtr, nameof (ZoneQuery));
      WorldZoneCollectionQueries.NativeMethodInfoPtr_Create_Public_Static_WorldZoneCollectionQueries_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldZoneCollectionQueries>.NativeClassPtr, 100682346);
      WorldZoneCollectionQueries.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WorldZoneCollectionQueries>.NativeClassPtr, 100682347);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WorldZoneCollectionQueries>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
