// Decompiled with JetBrains decompiler
// Type: ProjectM.BonfireAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Sequencer;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class BonfireAuthoring : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_InputItem;
    private static readonly IntPtr NativeFieldInfoPtr_BurnTime;
    private static readonly IntPtr NativeFieldInfoPtr_TimeToGetToFullStrength;
    private static readonly IntPtr NativeFieldInfoPtr_TimeToGetToZeroStrength;
    private static readonly IntPtr NativeFieldInfoPtr_StartScale;
    private static readonly IntPtr NativeFieldInfoPtr_EndScale;
    private static readonly IntPtr NativeFieldInfoPtr_ActiveSequence;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977492, XrefRangeEnd = 977501, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(BonfireAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977501, XrefRangeEnd = 977508, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), BonfireAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 977508, XrefRangeEnd = 977509, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe BonfireAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(BonfireAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static BonfireAuthoring()
    {
      Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (BonfireAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr);
      BonfireAuthoring.NativeFieldInfoPtr_InputItem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr, nameof (InputItem));
      BonfireAuthoring.NativeFieldInfoPtr_BurnTime = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr, nameof (BurnTime));
      BonfireAuthoring.NativeFieldInfoPtr_TimeToGetToFullStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr, nameof (TimeToGetToFullStrength));
      BonfireAuthoring.NativeFieldInfoPtr_TimeToGetToZeroStrength = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr, nameof (TimeToGetToZeroStrength));
      BonfireAuthoring.NativeFieldInfoPtr_StartScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr, nameof (StartScale));
      BonfireAuthoring.NativeFieldInfoPtr_EndScale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr, nameof (EndScale));
      BonfireAuthoring.NativeFieldInfoPtr_ActiveSequence = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr, nameof (ActiveSequence));
      BonfireAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr, 100675550);
      BonfireAuthoring.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr, 100675551);
      BonfireAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BonfireAuthoring>.NativeClassPtr, 100675552);
    }

    public BonfireAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe WeakAssetReference<ItemDataComponent> InputItem
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_InputItem));
        return pointer == IntPtr.Zero ? (WeakAssetReference<ItemDataComponent>) null : new WeakAssetReference<ItemDataComponent>(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_InputItem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe float BurnTime
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_BurnTime));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_BurnTime)) = value;
      }
    }

    public unsafe float TimeToGetToFullStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_TimeToGetToFullStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_TimeToGetToFullStrength)) = value;
      }
    }

    public unsafe float TimeToGetToZeroStrength
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_TimeToGetToZeroStrength));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_TimeToGetToZeroStrength)) = value;
      }
    }

    public unsafe float StartScale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_StartScale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_StartScale)) = value;
      }
    }

    public unsafe float EndScale
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_EndScale));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_EndScale)) = value;
      }
    }

    public unsafe SequenceField ActiveSequence
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_ActiveSequence));
        return pointer == IntPtr.Zero ? (SequenceField) null : new SequenceField(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(BonfireAuthoring.NativeFieldInfoPtr_ActiveSequence), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }
  }
}
