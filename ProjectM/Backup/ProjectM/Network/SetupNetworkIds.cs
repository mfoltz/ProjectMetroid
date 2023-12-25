// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.SetupNetworkIds
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SetupNetworkIds
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkIdToEntityMap;
    private static readonly System.IntPtr NativeFieldInfoPtr_FreeIds;
    private static readonly System.IntPtr NativeFieldInfoPtr_IdGenerations;
    private static readonly System.IntPtr NativeFieldInfoPtr_EntityTypeHandle;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkIdTypeHandle;
    private static readonly System.IntPtr NativeMethodInfoPtr_GrowIdGenerations_Public_Static_Void_NativeList_1_Byte_NativeQueue_1_Int32_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0;
    [FieldOffset(0)]
    public NativeHashMap<NetworkId, Entity> NetworkIdToEntityMap;
    [FieldOffset(16)]
    public NativeQueue<int> FreeIds;
    [FieldOffset(40)]
    public NativeList<byte> IdGenerations;
    [FieldOffset(56)]
    public EntityTypeHandle EntityTypeHandle;
    [FieldOffset(64)]
    public ComponentTypeHandle<NetworkId> NetworkIdTypeHandle;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 1155126, RefRangeEnd = 1155128, XrefRangeStart = 1155111, XrefRangeEnd = 1155126, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe void GrowIdGenerations(
      NativeList<byte> idGenerations,
      NativeQueue<int> freeIds,
      int maxNetworkIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &idGenerations;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &freeIds;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &maxNetworkIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupNetworkIds.NativeMethodInfoPtr_GrowIdGenerations_Public_Static_Void_NativeList_1_Byte_NativeQueue_1_Int32_Int32_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1155128, XrefRangeEnd = 1155192, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Execute(ArchetypeChunk chunk, int chunkIndex, int firstEntityIndex)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &chunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &chunkIndex;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &firstEntityIndex;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SetupNetworkIds.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static SetupNetworkIds()
    {
      Il2CppClassPointerStore<SetupNetworkIds>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Network", nameof (SetupNetworkIds));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SetupNetworkIds>.NativeClassPtr);
      SetupNetworkIds.NativeFieldInfoPtr_NetworkIdToEntityMap = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIds>.NativeClassPtr, nameof (NetworkIdToEntityMap));
      SetupNetworkIds.NativeFieldInfoPtr_FreeIds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIds>.NativeClassPtr, nameof (FreeIds));
      SetupNetworkIds.NativeFieldInfoPtr_IdGenerations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIds>.NativeClassPtr, nameof (IdGenerations));
      SetupNetworkIds.NativeFieldInfoPtr_EntityTypeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIds>.NativeClassPtr, nameof (EntityTypeHandle));
      SetupNetworkIds.NativeFieldInfoPtr_NetworkIdTypeHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SetupNetworkIds>.NativeClassPtr, nameof (NetworkIdTypeHandle));
      SetupNetworkIds.NativeMethodInfoPtr_GrowIdGenerations_Public_Static_Void_NativeList_1_Byte_NativeQueue_1_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIds>.NativeClassPtr, 100691895);
      SetupNetworkIds.NativeMethodInfoPtr_Execute_Public_Virtual_Final_New_Void_ArchetypeChunk_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SetupNetworkIds>.NativeClassPtr, 100691896);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SetupNetworkIds>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
