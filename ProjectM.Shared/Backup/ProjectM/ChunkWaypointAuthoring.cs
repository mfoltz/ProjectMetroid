// Decompiled with JetBrains decompiler
// Type: ProjectM.ChunkWaypointAuthoring
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;
using UnityEngine;

#nullable disable
namespace ProjectM
{
  public class ChunkWaypointAuthoring : MonoBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_DefaultUnlocked;
    private static readonly IntPtr NativeFieldInfoPtr_TeleportBuff;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 732447, XrefRangeEnd = 732452, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[3];
      numPtr[0] = (IntPtr) &entity;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(1) * sizeof (IntPtr))) = (IntPtr) &dstManager;
      *(IntPtr*) ((IntPtr) numPtr + checked (new IntPtr(2) * sizeof (IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkWaypointAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(520)]
    [CachedScanResults(RefRangeStart = 309669, RefRangeEnd = 310189, XrefRangeStart = 309669, XrefRangeEnd = 310189, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ChunkWaypointAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ChunkWaypointAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ChunkWaypointAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ChunkWaypointAuthoring()
    {
      Il2CppClassPointerStore<ChunkWaypointAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ChunkWaypointAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ChunkWaypointAuthoring>.NativeClassPtr);
      ChunkWaypointAuthoring.NativeFieldInfoPtr_DefaultUnlocked = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointAuthoring>.NativeClassPtr, nameof (DefaultUnlocked));
      ChunkWaypointAuthoring.NativeFieldInfoPtr_TeleportBuff = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ChunkWaypointAuthoring>.NativeClassPtr, nameof (TeleportBuff));
      ChunkWaypointAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkWaypointAuthoring>.NativeClassPtr, 100664720);
      ChunkWaypointAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ChunkWaypointAuthoring>.NativeClassPtr, 100664721);
    }

    public ChunkWaypointAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool DefaultUnlocked
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkWaypointAuthoring.NativeFieldInfoPtr_DefaultUnlocked));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkWaypointAuthoring.NativeFieldInfoPtr_DefaultUnlocked)) = value;
      }
    }

    public unsafe WeakAssetReference<TeleportBuffAuthoring> TeleportBuff
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ChunkWaypointAuthoring.NativeFieldInfoPtr_TeleportBuff));
        return pointer == IntPtr.Zero ? (WeakAssetReference<TeleportBuffAuthoring>) null : new WeakAssetReference<TeleportBuffAuthoring>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ChunkWaypointAuthoring.NativeFieldInfoPtr_TeleportBuff), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
