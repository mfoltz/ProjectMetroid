// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyUnitStatBuffComponent
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Malee;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ModifyUnitStatBuffComponent : StunlockBehaviour
  {
    private static readonly IntPtr NativeFieldInfoPtr_Modifications;
    private static readonly IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740211, XrefRangeEnd = 740278, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
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
      IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(425)]
    [CachedScanResults(RefRangeStart = 315604, RefRangeEnd = 316029, XrefRangeStart = 315604, XrefRangeEnd = 316029, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModifyUnitStatBuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyUnitStatBuffComponent>.NativeClassPtr))
    {
      IntPtr* numPtr = (IntPtr*) null;
      IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModifyUnitStatBuffComponent()
    {
      Il2CppClassPointerStore<ModifyUnitStatBuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ModifyUnitStatBuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyUnitStatBuffComponent>.NativeClassPtr);
      ModifyUnitStatBuffComponent.NativeFieldInfoPtr_Modifications = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyUnitStatBuffComponent>.NativeClassPtr, nameof (Modifications));
      ModifyUnitStatBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffComponent>.NativeClassPtr, 100665284);
      ModifyUnitStatBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffComponent>.NativeClassPtr, 100665285);
    }

    public ModifyUnitStatBuffComponent(IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe ModifyUnitStatBuffComponent.ModifyUnitStatBuffArray Modifications
    {
      get
      {
        IntPtr pointer = *(IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuffComponent.NativeFieldInfoPtr_Modifications));
        return pointer == IntPtr.Zero ? (ModifyUnitStatBuffComponent.ModifyUnitStatBuffArray) null : new ModifyUnitStatBuffComponent.ModifyUnitStatBuffArray(pointer);
      }
      [param: In] set
      {
        IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifyUnitStatBuffComponent.NativeFieldInfoPtr_Modifications), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    [Serializable]
    public class ModifyUnitStatBuffArray : ReorderableArray<ModifyUnitStatBuff_Editor>
    {
      private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 740208, XrefRangeEnd = 740211, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe ModifyUnitStatBuffArray()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyUnitStatBuffComponent.ModifyUnitStatBuffArray>.NativeClassPtr))
      {
        IntPtr* numPtr = (IntPtr*) null;
        IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ModifyUnitStatBuffComponent.ModifyUnitStatBuffArray.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static ModifyUnitStatBuffArray()
      {
        Il2CppClassPointerStore<ModifyUnitStatBuffComponent.ModifyUnitStatBuffArray>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyUnitStatBuffComponent>.NativeClassPtr, nameof (ModifyUnitStatBuffArray));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyUnitStatBuffComponent.ModifyUnitStatBuffArray>.NativeClassPtr);
        ModifyUnitStatBuffComponent.ModifyUnitStatBuffArray.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyUnitStatBuffComponent.ModifyUnitStatBuffArray>.NativeClassPtr, 100665286);
      }

      public ModifyUnitStatBuffArray(IntPtr pointer)
        : base(pointer)
      {
      }
    }
  }
}
