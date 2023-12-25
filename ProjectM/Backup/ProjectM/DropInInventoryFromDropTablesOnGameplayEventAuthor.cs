// Decompiled with JetBrains decompiler
// Type: ProjectM.DropInInventoryFromDropTablesOnGameplayEventAuthoring
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
  public class DropInInventoryFromDropTablesOnGameplayEventAuthoring : OnGameplayEventAuthoring
  {
    private static readonly IntPtr NativeFieldInfoPtr_Conditional;
    private static readonly IntPtr NativeFieldInfoPtr_DropAt;
    private static readonly IntPtr NativeFieldInfoPtr_DropTrigger;
    private static readonly IntPtr NativeFieldInfoPtr_ClearInventoryBeforeFill;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(41)]
    [CachedScanResults(RefRangeStart = 321963, RefRangeEnd = 322004, XrefRangeStart = 321963, XrefRangeEnd = 322004, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe DropInInventoryFromDropTablesOnGameplayEventAuthoring()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DropInInventoryFromDropTablesOnGameplayEventAuthoring>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static DropInInventoryFromDropTablesOnGameplayEventAuthoring()
    {
      Il2CppClassPointerStore<DropInInventoryFromDropTablesOnGameplayEventAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (DropInInventoryFromDropTablesOnGameplayEventAuthoring));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DropInInventoryFromDropTablesOnGameplayEventAuthoring>.NativeClassPtr);
      DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInInventoryFromDropTablesOnGameplayEventAuthoring>.NativeClassPtr, nameof (Conditional));
      DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_DropAt = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInInventoryFromDropTablesOnGameplayEventAuthoring>.NativeClassPtr, nameof (DropAt));
      DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_DropTrigger = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInInventoryFromDropTablesOnGameplayEventAuthoring>.NativeClassPtr, nameof (DropTrigger));
      DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_ClearInventoryBeforeFill = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DropInInventoryFromDropTablesOnGameplayEventAuthoring>.NativeClassPtr, nameof (ClearInventoryBeforeFill));
      DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInInventoryFromDropTablesOnGameplayEventAuthoring>.NativeClassPtr, 100678281);
      DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DropInInventoryFromDropTablesOnGameplayEventAuthoring>.NativeClassPtr, 100678282);
    }

    public DropInInventoryFromDropTablesOnGameplayEventAuthoring(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe GameplayConditionGroupData_Editor_Parent Conditional
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional));
        return pointer == IntPtr.Zero ? (GameplayConditionGroupData_Editor_Parent) null : new GameplayConditionGroupData_Editor_Parent(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_Conditional), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe DropAtLocation DropAt
    {
      get
      {
        return *(DropAtLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_DropAt));
      }
      [param: In] set
      {
        *(DropAtLocation*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_DropAt)) = value;
      }
    }

    public unsafe DropTriggerType DropTrigger
    {
      get
      {
        return *(DropTriggerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_DropTrigger));
      }
      [param: In] set
      {
        *(DropTriggerType*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_DropTrigger)) = value;
      }
    }

    public unsafe bool ClearInventoryBeforeFill
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_ClearInventoryBeforeFill));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(DropInInventoryFromDropTablesOnGameplayEventAuthoring.NativeFieldInfoPtr_ClearInventoryBeforeFill)) = value;
      }
    }
  }
}
