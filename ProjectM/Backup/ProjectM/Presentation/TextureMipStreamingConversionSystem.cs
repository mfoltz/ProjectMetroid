// Decompiled with JetBrains decompiler
// Type: ProjectM.Presentation.TextureMipStreamingConversionSystem
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppSystem.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

#nullable disable
namespace ProjectM.Presentation
{
  public class TextureMipStreamingConversionSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AllTextures;
    private static readonly System.IntPtr NativeFieldInfoPtr_TextureToIndex;
    private static readonly System.IntPtr NativeMethodInfoPtr_AddTexture_Public_Int32_Texture2D_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetMaterialData_Private_Void_Material_byref_MaterialData_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateTextureBundleEntity_Private_Void_byref_List_1_Texture2D_MeshRenderer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1113535, RefRangeEnd = 1113536, XrefRangeStart = 1113510, XrefRangeEnd = 1113535, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe int AddTexture(Texture2D texture)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) texture);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(TextureMipStreamingConversionSystem.NativeMethodInfoPtr_AddTexture_Public_Int32_Texture2D_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1113558, RefRangeEnd = 1113559, XrefRangeStart = 1113536, XrefRangeEnd = 1113558, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void GetMaterialData(
      Material material,
      out TextureMipStreamingConversionSystem.MaterialData outMaterialData)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) material);
      System.IntPtr num = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TextureMipStreamingConversionSystem.NativeMethodInfoPtr_GetMaterialData_Private_Void_Material_byref_MaterialData_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref TextureMipStreamingConversionSystem.MaterialData local = ref outMaterialData;
      System.IntPtr pointer = zero;
      TextureMipStreamingConversionSystem.MaterialData materialData = pointer == System.IntPtr.Zero ? (TextureMipStreamingConversionSystem.MaterialData) null : new TextureMipStreamingConversionSystem.MaterialData(pointer);
      local = materialData;
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113559, XrefRangeEnd = 1113588, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TextureMipStreamingConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113588, XrefRangeEnd = 1113594, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe void CreateTextureBundleEntity([In] ref List<Texture2D> allTextures, MeshRenderer lol)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr ptr = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) allTextures);
      System.IntPtr* numPtr3 = &ptr;
      *numPtr2 = (System.IntPtr) numPtr3;
      *(System.IntPtr*) ((System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) lol);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TextureMipStreamingConversionSystem.NativeMethodInfoPtr_CreateTextureBundleEntity_Private_Void_byref_List_1_Texture2D_MeshRenderer_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref List<Texture2D> local = ref allTextures;
      System.IntPtr pointer = ptr;
      List<> list = pointer == System.IntPtr.Zero ? (List<>) null : new List<>(pointer);
      local = (List<Texture2D>) list;
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe TextureMipStreamingConversionSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(TextureMipStreamingConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), TextureMipStreamingConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static TextureMipStreamingConversionSystem()
    {
      Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.Presentation", nameof (TextureMipStreamingConversionSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr);
      TextureMipStreamingConversionSystem.NativeFieldInfoPtr_AllTextures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr, nameof (AllTextures));
      TextureMipStreamingConversionSystem.NativeFieldInfoPtr_TextureToIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr, nameof (TextureToIndex));
      TextureMipStreamingConversionSystem.NativeMethodInfoPtr_AddTexture_Public_Int32_Texture2D_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr, 100688122);
      TextureMipStreamingConversionSystem.NativeMethodInfoPtr_GetMaterialData_Private_Void_Material_byref_MaterialData_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr, 100688123);
      TextureMipStreamingConversionSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr, 100688124);
      TextureMipStreamingConversionSystem.NativeMethodInfoPtr_CreateTextureBundleEntity_Private_Void_byref_List_1_Texture2D_MeshRenderer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr, 100688125);
      TextureMipStreamingConversionSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr, 100688126);
      TextureMipStreamingConversionSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr, 100688127);
    }

    public TextureMipStreamingConversionSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public unsafe List<Texture2D> AllTextures
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.NativeFieldInfoPtr_AllTextures));
        return pointer == System.IntPtr.Zero ? (List<Texture2D>) null : new List<Texture2D>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.NativeFieldInfoPtr_AllTextures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe Dictionary<Texture2D, int> TextureToIndex
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.NativeFieldInfoPtr_TextureToIndex));
        return pointer == System.IntPtr.Zero ? (Dictionary<Texture2D, int>) null : new Dictionary<Texture2D, int>(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.NativeFieldInfoPtr_TextureToIndex), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public sealed class MaterialData : Il2CppSystem.ValueType
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_material;
      private static readonly System.IntPtr NativeFieldInfoPtr_textures;

      static MaterialData()
      {
        Il2CppClassPointerStore<TextureMipStreamingConversionSystem.MaterialData>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr, nameof (MaterialData));
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.MaterialData>.NativeClassPtr);
        TextureMipStreamingConversionSystem.MaterialData.NativeFieldInfoPtr_material = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.MaterialData>.NativeClassPtr, nameof (material));
        TextureMipStreamingConversionSystem.MaterialData.NativeFieldInfoPtr_textures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.MaterialData>.NativeClassPtr, nameof (textures));
      }

      public MaterialData(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public MaterialData()
      {
        // ISSUE: cast to a reference type
        // ISSUE: untyped stack allocation
        System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.MaterialData>.NativeClassPtr, (uint&) System.IntPtr.Zero));
        // ISSUE: explicit constructor call
        base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.MaterialData>.NativeClassPtr, data));
      }

      public unsafe Material material
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.MaterialData.NativeFieldInfoPtr_material));
          return pointer == System.IntPtr.Zero ? (Material) null : new Material(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.MaterialData.NativeFieldInfoPtr_material), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe List<Texture2D> textures
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.MaterialData.NativeFieldInfoPtr_textures));
          return pointer == System.IntPtr.Zero ? (List<Texture2D>) null : new List<Texture2D>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.MaterialData.NativeFieldInfoPtr_textures), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }

    [ObfuscatedName("ProjectM.Presentation.TextureMipStreamingConversionSystem/<>c__DisplayClass5_0")]
    public sealed class __c__DisplayClass5_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_meshRenderer1;
      private static readonly System.IntPtr NativeFieldInfoPtr_materialCache;
      private static readonly System.IntPtr NativeFieldInfoPtr___4__this;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_MeshRenderer_MeshFilter_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass5_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.__c__DisplayClass5_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(0)]
      [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1113466, XrefRangeEnd = 1113510, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(MeshRenderer meshRenderer, MeshFilter meshFilter)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[2];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshRenderer);
        *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) meshFilter);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_MeshRenderer_MeshFilter_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass5_0()
      {
        Il2CppClassPointerStore<TextureMipStreamingConversionSystem.__c__DisplayClass5_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<TextureMipStreamingConversionSystem>.NativeClassPtr, "<>c__DisplayClass5_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.__c__DisplayClass5_0>.NativeClassPtr);
        TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_meshRenderer1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (meshRenderer1));
        TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_materialCache = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.__c__DisplayClass5_0>.NativeClassPtr, nameof (materialCache));
        TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.__c__DisplayClass5_0>.NativeClassPtr, "<>4__this");
        TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.__c__DisplayClass5_0>.NativeClassPtr, 100688128);
        TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_MeshRenderer_MeshFilter_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextureMipStreamingConversionSystem.__c__DisplayClass5_0>.NativeClassPtr, 100688129);
      }

      public __c__DisplayClass5_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe MeshRenderer meshRenderer1
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_meshRenderer1));
          return pointer == System.IntPtr.Zero ? (MeshRenderer) null : new MeshRenderer(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_meshRenderer1), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe Dictionary<Material, TextureMipStreamingConversionSystem.MaterialData> materialCache
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_materialCache));
          return pointer == System.IntPtr.Zero ? (Dictionary<Material, TextureMipStreamingConversionSystem.MaterialData>) null : new Dictionary<Material, TextureMipStreamingConversionSystem.MaterialData>(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr_materialCache), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }

      public unsafe TextureMipStreamingConversionSystem __4__this
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this));
          return pointer == System.IntPtr.Zero ? (TextureMipStreamingConversionSystem) null : new TextureMipStreamingConversionSystem(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextureMipStreamingConversionSystem.__c__DisplayClass5_0.NativeFieldInfoPtr___4__this), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
