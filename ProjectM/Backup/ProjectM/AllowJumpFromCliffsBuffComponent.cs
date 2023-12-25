// Decompiled with JetBrains decompiler
// Type: ProjectM.AllowJumpFromCliffsBuffComponent
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
  public class AllowJumpFromCliffsBuffComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_AllowJump;
    private static readonly IntPtr NativeFieldInfoPtr_BlockJump;
    private static readonly IntPtr NativeFieldInfoPtr_ModificationPriority;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1010562, XrefRangeEnd = 1010565, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(AllowJumpFromCliffsBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe AllowJumpFromCliffsBuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AllowJumpFromCliffsBuffComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(AllowJumpFromCliffsBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static AllowJumpFromCliffsBuffComponent()
    {
      Il2CppClassPointerStore<AllowJumpFromCliffsBuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AllowJumpFromCliffsBuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AllowJumpFromCliffsBuffComponent>.NativeClassPtr);
      AllowJumpFromCliffsBuffComponent.NativeFieldInfoPtr_AllowJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllowJumpFromCliffsBuffComponent>.NativeClassPtr, nameof (AllowJump));
      AllowJumpFromCliffsBuffComponent.NativeFieldInfoPtr_BlockJump = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllowJumpFromCliffsBuffComponent>.NativeClassPtr, nameof (BlockJump));
      AllowJumpFromCliffsBuffComponent.NativeFieldInfoPtr_ModificationPriority = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AllowJumpFromCliffsBuffComponent>.NativeClassPtr, nameof (ModificationPriority));
      AllowJumpFromCliffsBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllowJumpFromCliffsBuffComponent>.NativeClassPtr, 100678583);
      AllowJumpFromCliffsBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AllowJumpFromCliffsBuffComponent>.NativeClassPtr, 100678584);
    }

    public AllowJumpFromCliffsBuffComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool AllowJump
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AllowJumpFromCliffsBuffComponent.NativeFieldInfoPtr_AllowJump));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AllowJumpFromCliffsBuffComponent.NativeFieldInfoPtr_AllowJump)) = value;
      }
    }

    public unsafe bool BlockJump
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AllowJumpFromCliffsBuffComponent.NativeFieldInfoPtr_BlockJump));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AllowJumpFromCliffsBuffComponent.NativeFieldInfoPtr_BlockJump)) = value;
      }
    }

    public unsafe int ModificationPriority
    {
      get
      {
        return *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AllowJumpFromCliffsBuffComponent.NativeFieldInfoPtr_ModificationPriority));
      }
      [param: In] set
      {
        *(int*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(AllowJumpFromCliffsBuffComponent.NativeFieldInfoPtr_ModificationPriority)) = value;
      }
    }
  }
}
