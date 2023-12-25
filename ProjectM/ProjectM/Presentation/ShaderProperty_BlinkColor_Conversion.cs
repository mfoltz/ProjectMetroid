// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.ShaderProperty_BlinkColor_Conversion
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using ProjectM.Physics;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public class ShaderProperty_BlinkColor_Conversion : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113384, XrefRangeEnd = 1113466, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShaderProperty_BlinkColor_Conversion.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ShaderProperty_BlinkColor_Conversion()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ShaderProperty_BlinkColor_Conversion.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ShaderProperty_BlinkColor_Conversion.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ShaderProperty_BlinkColor_Conversion()
    {
      Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (ShaderProperty_BlinkColor_Conversion));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion>.NativeClassPtr);
      ShaderProperty_BlinkColor_Conversion.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion>.NativeClassPtr, 100688109);
      ShaderProperty_BlinkColor_Conversion.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion>.NativeClassPtr, 100688110);
      ShaderProperty_BlinkColor_Conversion.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion>.NativeClassPtr, 100688111);
    }

    public ShaderProperty_BlinkColor_Conversion(System.IntPtr pointer)
      : base(pointer)
    {
    }

    [StructLayout(LayoutKind.Explicit)]
    public struct CachedShaderEntry
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_HasBlink;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasDissolve;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasDither;
      private static readonly System.IntPtr NativeFieldInfoPtr_HasAlphaMultiply;
      [FieldOffset(0)]
      public bool HasBlink;
      [FieldOffset(1)]
      public bool HasDissolve;
      [FieldOffset(2)]
      public bool HasDither;
      [FieldOffset(3)]
      public bool HasAlphaMultiply;

      static CachedShaderEntry()
      {
        Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.CachedShaderEntry>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion>.NativeClassPtr, nameof (CachedShaderEntry));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.CachedShaderEntry>.NativeClassPtr);
        ShaderProperty_BlinkColor_Conversion.CachedShaderEntry.NativeFieldInfoPtr_HasBlink = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.CachedShaderEntry>.NativeClassPtr, nameof (HasBlink));
        ShaderProperty_BlinkColor_Conversion.CachedShaderEntry.NativeFieldInfoPtr_HasDissolve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.CachedShaderEntry>.NativeClassPtr, nameof (HasDissolve));
        ShaderProperty_BlinkColor_Conversion.CachedShaderEntry.NativeFieldInfoPtr_HasDither = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.CachedShaderEntry>.NativeClassPtr, nameof (HasDither));
        ShaderProperty_BlinkColor_Conversion.CachedShaderEntry.NativeFieldInfoPtr_HasAlphaMultiply = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.CachedShaderEntry>.NativeClassPtr, nameof (HasAlphaMultiply));
      }

      public Il2CppSystem.Object BoxIl2CppObject()
      {
        return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.CachedShaderEntry>.NativeClassPtr, (System.IntPtr) ref this));
      }
    }

    [ObfuscatedName("ProjectM.Presentation.ShaderProperty_BlinkColor_Conversion/<>c__DisplayClass1_0")]
    public sealed class __c__DisplayClass1_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_meshRenderers;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeFieldInfoPtr_shaderPropertyCache;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_HealthComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_BlueprintDataComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_PhysicsRubbleAuthoring_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_WallpaperVariationComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_NetworkedSpawnChainChildAuthoring_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_ImpactMaterialComponent_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_MeshRenderer_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass1_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113017, XrefRangeEnd = 1113058, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(HealthComponent healthComponent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) healthComponent);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_HealthComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113058, XrefRangeEnd = 1113115, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__1(BlueprintDataComponent blueprintDataComponent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) blueprintDataComponent);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_BlueprintDataComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113115, XrefRangeEnd = 1113156, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__2(PhysicsRubbleAuthoring physicsRubbleAuthoring)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) physicsRubbleAuthoring);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_PhysicsRubbleAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113156, XrefRangeEnd = 1113213, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__3(
        WallpaperVariationComponent wallpaperVariationComponent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) wallpaperVariationComponent);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_WallpaperVariationComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113213, XrefRangeEnd = 1113270, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__4(
        NetworkedSpawnChainChildAuthoring networkedSpawnChainChild)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) networkedSpawnChainChild);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_NetworkedSpawnChainChildAuthoring_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113270, XrefRangeEnd = 1113311, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__5(ImpactMaterialComponent impactMaterialComponent)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) impactMaterialComponent);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_ImpactMaterialComponent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113311, XrefRangeEnd = 1113384, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__6(MeshRenderer meshRenderer)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshRenderer);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass1_0()
      {
        Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion>.NativeClassPtr, "<>c__DisplayClass1_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr);
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeFieldInfoPtr_meshRenderers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, nameof (meshRenderers));
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, "<>4__this");
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeFieldInfoPtr_shaderPropertyCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, nameof (shaderPropertyCache));
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, 100688112);
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_HealthComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, 100688113);
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__1_Internal_Void_BlueprintDataComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, 100688114);
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__2_Internal_Void_PhysicsRubbleAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, 100688115);
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__3_Internal_Void_WallpaperVariationComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, 100688116);
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__4_Internal_Void_NetworkedSpawnChainChildAuthoring_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, 100688117);
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__5_Internal_Void_ImpactMaterialComponent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, 100688118);
        ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeMethodInfoPtr__OnUpdate_b__6_Internal_Void_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0>.NativeClassPtr, 100688119);
      }

      public __c__DisplayClass1_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe List<MeshRenderer> meshRenderers
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeFieldInfoPtr_meshRenderers));
          return pointer == System.IntPtr.Zero ? (List<MeshRenderer>) null : new List<MeshRenderer>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeFieldInfoPtr_meshRenderers), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe ShaderProperty_BlinkColor_Conversion __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (ShaderProperty_BlinkColor_Conversion) null : new ShaderProperty_BlinkColor_Conversion(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<Shader, ShaderProperty_BlinkColor_Conversion.CachedShaderEntry> shaderPropertyCache
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeFieldInfoPtr_shaderPropertyCache));
          return pointer == System.IntPtr.Zero ? (Dictionary<Shader, ShaderProperty_BlinkColor_Conversion.CachedShaderEntry>) null : new Dictionary<Shader, ShaderProperty_BlinkColor_Conversion.CachedShaderEntry>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ShaderProperty_BlinkColor_Conversion.__c__DisplayClass1_0.NativeFieldInfoPtr_shaderPropertyCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
