// Decompiled with JetBrains decompiler
// Type: ProjectM.DeathPvPTimerComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class DeathPvPTimerComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_ExtraTime_FirstStack;
    private static readonly IntPtr NativeFieldInfoPtr_ExtraTime_AdditionalStacks;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726669, XrefRangeEnd = 726672, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(DeathPvPTimerComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726672, XrefRangeEnd = 726676, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void GetRequiredNetworked(SyncedCollection syncedCollection)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      IntPtr* numPtr = stackalloc IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) syncedCollection);
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), DeathPvPTimerComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 726676, XrefRangeEnd = 726677, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DeathPvPTimerComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DeathPvPTimerComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DeathPvPTimerComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DeathPvPTimerComponent()
    {
      Il2CppClassPointerStore<DeathPvPTimerComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DeathPvPTimerComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DeathPvPTimerComponent>.NativeClassPtr);
      DeathPvPTimerComponent.NativeFieldInfoPtr_ExtraTime_FirstStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathPvPTimerComponent>.NativeClassPtr, nameof (ExtraTime_FirstStack));
      DeathPvPTimerComponent.NativeFieldInfoPtr_ExtraTime_AdditionalStacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DeathPvPTimerComponent>.NativeClassPtr, nameof (ExtraTime_AdditionalStacks));
      DeathPvPTimerComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathPvPTimerComponent>.NativeClassPtr, 100664230);
      DeathPvPTimerComponent.NativeMethodInfoPtr_GetRequiredNetworked_Public_Virtual_Void_SyncedCollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathPvPTimerComponent>.NativeClassPtr, 100664231);
      DeathPvPTimerComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DeathPvPTimerComponent>.NativeClassPtr, 100664232);
    }

    public DeathPvPTimerComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe float ExtraTime_FirstStack
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathPvPTimerComponent.NativeFieldInfoPtr_ExtraTime_FirstStack));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathPvPTimerComponent.NativeFieldInfoPtr_ExtraTime_FirstStack)) = value;
      }
    }

    public unsafe float ExtraTime_AdditionalStacks
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathPvPTimerComponent.NativeFieldInfoPtr_ExtraTime_AdditionalStacks));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DeathPvPTimerComponent.NativeFieldInfoPtr_ExtraTime_AdditionalStacks)) = value;
      }
    }
  }
}
