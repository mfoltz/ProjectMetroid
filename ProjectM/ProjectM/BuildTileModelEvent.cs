// Decompiled with JetBrains decompiler
// Type: ProjectM.BuildTileModelEvent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Network;
using ProjectM.Tiles;
using Stunlock.Network;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Transforms;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct BuildTileModelEvent
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_PrefabGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTranslation;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpawnTileRotation;
    private static readonly System.IntPtr NativeFieldInfoPtr_TransformedEntity;
    private static readonly System.IntPtr NativeFieldInfoPtr_VariationIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0;
    [FieldOffset(0)]
    public PrefabGUID PrefabGuid;
    [FieldOffset(4)]
    public Translation SpawnTranslation;
    [FieldOffset(16)]
    public TileRotation SpawnTileRotation;
    [FieldOffset(20)]
    public NetworkId TransformedEntity;
    [FieldOffset(28)]
    public byte VariationIndex;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1026167, XrefRangeEnd = 1026177, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Serialize(ref NetBufferOut netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildTileModelEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1026187, RefRangeEnd = 1026188, XrefRangeStart = 1026177, XrefRangeEnd = 1026187, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Deserialize(ref NetBufferIn netBuffer, EntityManager entityManager)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref netBuffer;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entityManager;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BuildTileModelEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BuildTileModelEvent()
    {
      Il2CppClassPointerStore<BuildTileModelEvent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BuildTileModelEvent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BuildTileModelEvent>.NativeClassPtr);
      BuildTileModelEvent.NativeFieldInfoPtr_PrefabGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTileModelEvent>.NativeClassPtr, nameof (PrefabGuid));
      BuildTileModelEvent.NativeFieldInfoPtr_SpawnTranslation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTileModelEvent>.NativeClassPtr, nameof (SpawnTranslation));
      BuildTileModelEvent.NativeFieldInfoPtr_SpawnTileRotation = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTileModelEvent>.NativeClassPtr, nameof (SpawnTileRotation));
      BuildTileModelEvent.NativeFieldInfoPtr_TransformedEntity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTileModelEvent>.NativeClassPtr, nameof (TransformedEntity));
      BuildTileModelEvent.NativeFieldInfoPtr_VariationIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BuildTileModelEvent>.NativeClassPtr, nameof (VariationIndex));
      BuildTileModelEvent.NativeMethodInfoPtr_Serialize_Public_Virtual_Final_New_Void_byref_NetBufferOut_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTileModelEvent>.NativeClassPtr, 100680218);
      BuildTileModelEvent.NativeMethodInfoPtr_Deserialize_Public_Virtual_Final_New_Void_byref_NetBufferIn_EntityManager_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BuildTileModelEvent>.NativeClassPtr, 100680219);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<BuildTileModelEvent>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
