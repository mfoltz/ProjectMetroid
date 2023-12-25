// Decompiled with JetBrains decompiler
// Type: ProjectM.CreateGameplayEventOnDestroyAuthoring
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
  public class CreateGameplayEventOnDestroyAuthoring : CreateGameplayEventAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Id;
    private static readonly IntPtr NativeFieldInfoPtr_Target;
    private static readonly IntPtr NativeFieldInfoPtr_SpecificDestroyReason;
    private static readonly IntPtr NativeFieldInfoPtr_DestroyReason;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1007572, XrefRangeEnd = 1007586, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventOnDestroyAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe CreateGameplayEventOnDestroyAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CreateGameplayEventOnDestroyAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateGameplayEventOnDestroyAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreateGameplayEventOnDestroyAuthoring()
    {
      Il2CppClassPointerStore<CreateGameplayEventOnDestroyAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (CreateGameplayEventOnDestroyAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateGameplayEventOnDestroyAuthoring>.NativeClassPtr);
      CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_Id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnDestroyAuthoring>.NativeClassPtr, nameof (Id));
      CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnDestroyAuthoring>.NativeClassPtr, nameof (Target));
      CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_SpecificDestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnDestroyAuthoring>.NativeClassPtr, nameof (SpecificDestroyReason));
      CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_DestroyReason = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateGameplayEventOnDestroyAuthoring>.NativeClassPtr, nameof (DestroyReason));
      CreateGameplayEventOnDestroyAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventOnDestroyAuthoring>.NativeClassPtr, 100678203);
      CreateGameplayEventOnDestroyAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateGameplayEventOnDestroyAuthoring>.NativeClassPtr, 100678204);
    }

    public CreateGameplayEventOnDestroyAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe int Id
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_Id));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_Id)) = value;
      }
    }

    public unsafe GameplayEventTarget Target
    {
      get
      {
        return *(GameplayEventTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_Target));
      }
      [param: In] set
      {
        *(GameplayEventTarget*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_Target)) = value;
      }
    }

    public unsafe bool SpecificDestroyReason
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_SpecificDestroyReason));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_SpecificDestroyReason)) = value;
      }
    }

    public unsafe DestroyReason DestroyReason
    {
      get
      {
        return *(DestroyReason*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_DestroyReason));
      }
      [param: In] set
      {
        *(DestroyReason*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(CreateGameplayEventOnDestroyAuthoring.NativeFieldInfoPtr_DestroyReason)) = value;
      }
    }
  }
}
