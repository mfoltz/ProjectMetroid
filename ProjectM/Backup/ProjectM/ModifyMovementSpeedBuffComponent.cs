// Decompiled with JetBrains decompiler
// Type: ProjectM.ModifyMovementSpeedBuffComponent
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using System;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  public class ModifyMovementSpeedBuffComponent : StunlockBehaviour
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_StackIncrease;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveSpeedPerStack;
    private static readonly System.IntPtr NativeFieldInfoPtr_MoveSpeed;
    private static readonly System.IntPtr NativeFieldInfoPtr_MultiplyAdd;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellMods;
    private static readonly System.IntPtr NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001087, XrefRangeEnd = 1001097, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Convert(
      Entity entity,
      EntityManager dstManager,
      GameObjectConversionSystem conversionSystem)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &entity;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &dstManager;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) conversionSystem);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyMovementSpeedBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1001097, XrefRangeEnd = 1001098, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ModifyMovementSpeedBuffComponent()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ModifyMovementSpeedBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ModifyMovementSpeedBuffComponent()
    {
      Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (ModifyMovementSpeedBuffComponent));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr);
      ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_StackIncrease = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr, nameof (StackIncrease));
      ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_MoveSpeedPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr, nameof (MoveSpeedPerStack));
      ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr, nameof (MoveSpeed));
      ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_MultiplyAdd = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr, nameof (MultiplyAdd));
      ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr, nameof (Curve));
      ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_SpellMods = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr, nameof (SpellMods));
      ModifyMovementSpeedBuffComponent.NativeMethodInfoPtr_Convert_Public_Virtual_Final_New_Void_Entity_EntityManager_GameObjectConversionSystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr, 100677492);
      ModifyMovementSpeedBuffComponent.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr, 100677493);
    }

    public ModifyMovementSpeedBuffComponent(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe bool StackIncrease
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_StackIncrease));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_StackIncrease)) = value;
      }
    }

    public unsafe float MoveSpeedPerStack
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_MoveSpeedPerStack));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_MoveSpeedPerStack)) = value;
      }
    }

    public unsafe float MoveSpeed
    {
      get
      {
        return *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_MoveSpeed));
      }
      [param: In] set
      {
        *(float*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_MoveSpeed)) = value;
      }
    }

    public unsafe bool MultiplyAdd
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_MultiplyAdd));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_MultiplyAdd)) = value;
      }
    }

    public unsafe CurveReference Curve
    {
      get
      {
        return *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_Curve));
      }
      [param: In] set
      {
        *(CurveReference*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_Curve)) = value;
      }
    }

    public ModifyMovementSpeedBuffComponent.SpellModsAuthoring SpellMods
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_SpellMods);
        return new ModifyMovementSpeedBuffComponent.SpellModsAuthoring(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.NativeFieldInfoPtr_SpellMods), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }

    [Serializable]
    public sealed class SpellModsAuthoring : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_MoveSpeed;
      private static readonly System.IntPtr NativeFieldInfoPtr_MoveSpeedPerStack;

      static SpellModsAuthoring()
      {
        Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent.SpellModsAuthoring>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent>.NativeClassPtr, nameof (SpellModsAuthoring));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent.SpellModsAuthoring>.NativeClassPtr);
        ModifyMovementSpeedBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MoveSpeed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MoveSpeed));
        ModifyMovementSpeedBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MoveSpeedPerStack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent.SpellModsAuthoring>.NativeClassPtr, nameof (MoveSpeedPerStack));
      }

      public SpellModsAuthoring(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public SpellModsAuthoring()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent.SpellModsAuthoring>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ModifyMovementSpeedBuffComponent.SpellModsAuthoring>.NativeClassPtr, data));
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MoveSpeed
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MoveSpeed));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MoveSpeed), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Il2CppReferenceArray<SpellModArithmeticSettings> MoveSpeedPerStack
      {
        get
        {
          System.IntPtr nativeObject = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MoveSpeedPerStack));
          return nativeObject == System.IntPtr.Zero ? (Il2CppReferenceArray<SpellModArithmeticSettings>) null : new Il2CppReferenceArray<SpellModArithmeticSettings>(nativeObject);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ModifyMovementSpeedBuffComponent.SpellModsAuthoring.NativeFieldInfoPtr_MoveSpeedPerStack), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
