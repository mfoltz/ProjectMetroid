// Decompiled with JetBrains decompiler
// Type: ProjectM.Network.DeserializeEntityParams
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using ProjectM.Terrain;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM.Network
{
  [StructLayout(LayoutKind.Explicit)]
  public struct DeserializeEntityParams
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_UserChunk;
    private static readonly System.IntPtr NativeFieldInfoPtr_Entity;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkId;
    private static readonly System.IntPtr NativeFieldInfoPtr_NetworkSnapshot;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellModsClient;
    private static readonly System.IntPtr NativeFieldInfoPtr_WeakRefTracker;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_TerrainChunk_Entity_NetworkId_NetworkSnapshot_WeakRefTracker_SyncRegistry_Client_1_SpellModSet_0;
    [FieldOffset(0)]
    public readonly TerrainChunk UserChunk;
    [FieldOffset(8)]
    public readonly Entity Entity;
    [FieldOffset(16)]
    public readonly NetworkId NetworkId;
    [FieldOffset(24)]
    public readonly NetworkSnapshot NetworkSnapshot;
    [FieldOffset(32)]
    public SyncRegistry_Client<SpellModSet> SpellModsClient;
    [FieldOffset(64)]
    public WeakRefTracker WeakRefTracker;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 785303, RefRangeEnd = 785304, XrefRangeStart = 785303, XrefRangeEnd = 785303, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DeserializeEntityParams(
      TerrainChunk userChunk,
      Entity entity,
      NetworkId networkId,
      NetworkSnapshot networkSnapshot,
      WeakRefTracker weakRefTracker,
      SyncRegistry_Client<SpellModSet> spellModsClient)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[6];
      numPtr[0] = (System.IntPtr) &userChunk;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &networkId;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &networkSnapshot;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(4) * sizeof (System.IntPtr))) = (System.IntPtr) &weakRefTracker;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(5) * sizeof (System.IntPtr))) = (System.IntPtr) &spellModsClient;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeserializeEntityParams.NativeMethodInfoPtr__ctor_Public_Void_TerrainChunk_Entity_NetworkId_NetworkSnapshot_WeakRefTracker_SyncRegistry_Client_1_SpellModSet_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeserializeEntityParams()
    {
      Il2CppClassPointerStore<DeserializeEntityParams>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Network", nameof (DeserializeEntityParams));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeserializeEntityParams>.NativeClassPtr);
      DeserializeEntityParams.NativeFieldInfoPtr_UserChunk = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeEntityParams>.NativeClassPtr, nameof (UserChunk));
      DeserializeEntityParams.NativeFieldInfoPtr_Entity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeEntityParams>.NativeClassPtr, nameof (Entity));
      DeserializeEntityParams.NativeFieldInfoPtr_NetworkId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeEntityParams>.NativeClassPtr, nameof (NetworkId));
      DeserializeEntityParams.NativeFieldInfoPtr_NetworkSnapshot = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeEntityParams>.NativeClassPtr, nameof (NetworkSnapshot));
      DeserializeEntityParams.NativeFieldInfoPtr_SpellModsClient = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeEntityParams>.NativeClassPtr, nameof (SpellModsClient));
      DeserializeEntityParams.NativeFieldInfoPtr_WeakRefTracker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeserializeEntityParams>.NativeClassPtr, nameof (WeakRefTracker));
      DeserializeEntityParams.NativeMethodInfoPtr__ctor_Public_Void_TerrainChunk_Entity_NetworkId_NetworkSnapshot_WeakRefTracker_SyncRegistry_Client_1_SpellModSet_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeserializeEntityParams>.NativeClassPtr, 100669198);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DeserializeEntityParams>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
