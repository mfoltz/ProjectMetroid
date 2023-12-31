// Decompiled with JetBrains decompiler
// Type: ProjectM.NetherSpawnPositionMetadata
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Mathematics;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct NetherSpawnPositionMetadata
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaxPositions;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pos0;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pos1;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pos2;
    private static readonly System.IntPtr NativeFieldInfoPtr_Pos3;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_Item_Public_get_SpawnPosition_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_SpawnPosition_0;
    [FieldOffset(0)]
    public NetherSpawnPositionMetadata.SpawnPosition Pos0;
    [FieldOffset(80)]
    public NetherSpawnPositionMetadata.SpawnPosition Pos1;
    [FieldOffset(160)]
    public NetherSpawnPositionMetadata.SpawnPosition Pos2;
    [FieldOffset(240)]
    public NetherSpawnPositionMetadata.SpawnPosition Pos3;

    public unsafe NetherSpawnPositionMetadata.SpawnPosition this[int index]
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 727432, RefRangeEnd = 727435, XrefRangeStart = 727432, XrefRangeEnd = 727432, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &index;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(NetherSpawnPositionMetadata.NativeMethodInfoPtr_get_Item_Public_get_SpawnPosition_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(NetherSpawnPositionMetadata.SpawnPosition*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(1), CachedScanResults(RefRangeStart = 727435, RefRangeEnd = 727436, XrefRangeStart = 727435, XrefRangeEnd = 727435, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = (System.IntPtr) &index;
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(NetherSpawnPositionMetadata.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_SpawnPosition_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    static NetherSpawnPositionMetadata()
    {
      Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (NetherSpawnPositionMetadata));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr);
      NetherSpawnPositionMetadata.NativeFieldInfoPtr_MaxPositions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr, nameof (MaxPositions));
      NetherSpawnPositionMetadata.NativeFieldInfoPtr_Pos0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr, nameof (Pos0));
      NetherSpawnPositionMetadata.NativeFieldInfoPtr_Pos1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr, nameof (Pos1));
      NetherSpawnPositionMetadata.NativeFieldInfoPtr_Pos2 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr, nameof (Pos2));
      NetherSpawnPositionMetadata.NativeFieldInfoPtr_Pos3 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr, nameof (Pos3));
      NetherSpawnPositionMetadata.NativeMethodInfoPtr_get_Item_Public_get_SpawnPosition_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr, 100664375);
      NetherSpawnPositionMetadata.NativeMethodInfoPtr_set_Item_Public_set_Void_Int32_SpawnPosition_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr, 100664376);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr, (System.IntPtr) ref this));
    }

    public static unsafe int MaxPositions
    {
      get
      {
        int maxPositions;
        IL2CPP.il2cpp_field_static_get_value(NetherSpawnPositionMetadata.NativeFieldInfoPtr_MaxPositions, (void*) &maxPositions);
        return maxPositions;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(NetherSpawnPositionMetadata.NativeFieldInfoPtr_MaxPositions, (void*) &value);
      }
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct SpawnPosition
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_SpawnPosGUID;
      private static readonly System.IntPtr NativeFieldInfoPtr_LocalChunkTRS;
      private static readonly System.IntPtr NativeFieldInfoPtr_TransformIndex;
      [FieldOffset(0)]
      public PrefabGUID SpawnPosGUID;
      [FieldOffset(4)]
      public float4x4 LocalChunkTRS;
      [FieldOffset(68)]
      public StaticTransformIndex TransformIndex;

      static SpawnPosition()
      {
        Il2CppClassPointerStore<NetherSpawnPositionMetadata.SpawnPosition>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NetherSpawnPositionMetadata>.NativeClassPtr, nameof (SpawnPosition));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NetherSpawnPositionMetadata.SpawnPosition>.NativeClassPtr);
        NetherSpawnPositionMetadata.SpawnPosition.NativeFieldInfoPtr_SpawnPosGUID = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionMetadata.SpawnPosition>.NativeClassPtr, nameof (SpawnPosGUID));
        NetherSpawnPositionMetadata.SpawnPosition.NativeFieldInfoPtr_LocalChunkTRS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionMetadata.SpawnPosition>.NativeClassPtr, nameof (LocalChunkTRS));
        NetherSpawnPositionMetadata.SpawnPosition.NativeFieldInfoPtr_TransformIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NetherSpawnPositionMetadata.SpawnPosition>.NativeClassPtr, nameof (TransformIndex));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NetherSpawnPositionMetadata.SpawnPosition>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }
  }
}
