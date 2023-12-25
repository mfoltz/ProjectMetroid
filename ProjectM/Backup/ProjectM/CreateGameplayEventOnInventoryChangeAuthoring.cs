// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventOnInventoryChangeAuthoring
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class CreateGameplayEventOnInventoryChangeAuthoring : CreateGameplayEventAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_TriggerMultipleTimes;
    private static readonly IntPtr NativeFieldInfoPtr_ChangeType;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1012809, XrefRangeEnd = 1012823, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventOnInventoryChangeAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreateGameplayEventOnInventoryChangeAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChangeAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventOnInventoryChangeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreateGameplayEventOnInventoryChangeAuthoring()
    {
      Il2CppClassPointerStore<CreateGameplayEventOnInventoryChangeAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventOnInventoryChangeAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChangeAuthoring>.NativeClassPtr);
      CreateGameplayEventOnInventoryChangeAuthoring.NativeFieldInfoPtr_TriggerMultipleTimes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChangeAuthoring>.NativeClassPtr, nameof (TriggerMultipleTimes));
      CreateGameplayEventOnInventoryChangeAuthoring.NativeFieldInfoPtr_ChangeType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChangeAuthoring>.NativeClassPtr, nameof (ChangeType));
      CreateGameplayEventOnInventoryChangeAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChangeAuthoring>.NativeClassPtr, 100678921);
      CreateGameplayEventOnInventoryChangeAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventOnInventoryChangeAuthoring>.NativeClassPtr, 100678922);
    }

    public CreateGameplayEventOnInventoryChangeAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool TriggerMultipleTimes
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnInventoryChangeAuthoring.NativeFieldInfoPtr_TriggerMultipleTimes));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnInventoryChangeAuthoring.NativeFieldInfoPtr_TriggerMultipleTimes)) = value;
      }
    }

    public unsafe InventoryChangeType ChangeType
    {
      get
      {
        return *(InventoryChangeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnInventoryChangeAuthoring.NativeFieldInfoPtr_ChangeType));
      }
      [param: In] set
      {
        *(InventoryChangeType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnInventoryChangeAuthoring.NativeFieldInfoPtr_ChangeType)) = value;
      }
    }
  }
}
