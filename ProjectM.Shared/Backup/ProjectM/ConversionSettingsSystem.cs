// Decompiled with JetBrains decompiler
// Type: ProjectM.ConversionSettingsSystem
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  public class ConversionSettingsSystem : GameObjectConversionSystem
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__InitializedConversionTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr__ConversionTarget;
    private static readonly System.IntPtr NativeFieldInfoPtr_AcceptConversionWithoutSettingsAsset;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ApplicationConversionTarget_Public_Static_get_ApplicationConversionTarget_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0;

    public static unsafe ApplicationConversionTarget ApplicationConversionTarget
    {
      [CallerCount(4), CachedScanResults(RefRangeStart = 734866, RefRangeEnd = 734870, XrefRangeStart = 734857, XrefRangeEnd = 734866, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(ConversionSettingsSystem.NativeMethodInfoPtr_get_ApplicationConversionTarget_Public_Static_get_ApplicationConversionTarget_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(ApplicationConversionTarget*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734870, XrefRangeEnd = 734874, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConversionSettingsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 734874, XrefRangeEnd = 734935, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnUpdate()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConversionSettingsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(105)]
    [CachedScanResults(RefRangeStart = 73174, RefRangeEnd = 73279, XrefRangeStart = 73174, XrefRangeEnd = 73279, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe ConversionSettingsSystem()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(ConversionSettingsSystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1696)]
    [CachedScanResults(RefRangeStart = 37044, RefRangeEnd = 38740, XrefRangeStart = 37044, XrefRangeEnd = 38740, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe void OnCreateForCompiler()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) this), ConversionSettingsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static ConversionSettingsSystem()
    {
      Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (ConversionSettingsSystem));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr);
      ConversionSettingsSystem.NativeFieldInfoPtr__InitializedConversionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr, nameof (_InitializedConversionTarget));
      ConversionSettingsSystem.NativeFieldInfoPtr__ConversionTarget = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr, nameof (_ConversionTarget));
      ConversionSettingsSystem.NativeFieldInfoPtr_AcceptConversionWithoutSettingsAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr, nameof (AcceptConversionWithoutSettingsAsset));
      ConversionSettingsSystem.NativeMethodInfoPtr_get_ApplicationConversionTarget_Public_Static_get_ApplicationConversionTarget_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr, 100664895);
      ConversionSettingsSystem.NativeMethodInfoPtr_OnCreate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr, 100664896);
      ConversionSettingsSystem.NativeMethodInfoPtr_OnUpdate_Protected_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr, 100664897);
      ConversionSettingsSystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr, 100664898);
      ConversionSettingsSystem.NativeMethodInfoPtr_OnCreateForCompiler_FamOrAssem_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr, 100664899);
    }

    public ConversionSettingsSystem(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe bool _InitializedConversionTarget
    {
      get
      {
        bool conversionTarget;
        IL2CPP.il2cpp_field_static_get_value(ConversionSettingsSystem.NativeFieldInfoPtr__InitializedConversionTarget, (void*) &conversionTarget);
        return conversionTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConversionSettingsSystem.NativeFieldInfoPtr__InitializedConversionTarget, (void*) &value);
      }
    }

    public static unsafe ApplicationConversionTarget _ConversionTarget
    {
      get
      {
        ApplicationConversionTarget conversionTarget;
        IL2CPP.il2cpp_field_static_get_value(ConversionSettingsSystem.NativeFieldInfoPtr__ConversionTarget, (void*) &conversionTarget);
        return conversionTarget;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(ConversionSettingsSystem.NativeFieldInfoPtr__ConversionTarget, (void*) &value);
      }
    }

    public unsafe bool AcceptConversionWithoutSettingsAsset
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConversionSettingsSystem.NativeFieldInfoPtr_AcceptConversionWithoutSettingsAsset));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConversionSettingsSystem.NativeFieldInfoPtr_AcceptConversionWithoutSettingsAsset)) = value;
      }
    }

    [ObfuscatedName("ProjectM.ConversionSettingsSystem/<>c__DisplayClass6_0")]
    public sealed class __c__DisplayClass6_0 : Il2CppSystem.Object
    {
      private static readonly System.IntPtr NativeFieldInfoPtr_conversionSettingsAsset;
      private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
      private static readonly System.IntPtr NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_ConversionSettingsAsset_0;

      [CallerCount(3875)]
      [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe __c__DisplayClass6_0()
        : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConversionSettingsSystem.__c__DisplayClass6_0>.NativeClassPtr))
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ConversionSettingsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      [CallerCount(4)]
      [CachedScanResults(RefRangeStart = 16451, RefRangeEnd = 16455, XrefRangeStart = 16451, XrefRangeEnd = 16455, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
      public unsafe void _OnUpdate_b__0(ConversionSettingsAsset asset)
      {
        IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) asset);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(ConversionSettingsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_ConversionSettingsAsset_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }

      static __c__DisplayClass6_0()
      {
        Il2CppClassPointerStore<ConversionSettingsSystem.__c__DisplayClass6_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ConversionSettingsSystem>.NativeClassPtr, "<>c__DisplayClass6_0");
        IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConversionSettingsSystem.__c__DisplayClass6_0>.NativeClassPtr);
        ConversionSettingsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_conversionSettingsAsset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConversionSettingsSystem.__c__DisplayClass6_0>.NativeClassPtr, nameof (conversionSettingsAsset));
        ConversionSettingsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionSettingsSystem.__c__DisplayClass6_0>.NativeClassPtr, 100664900);
        ConversionSettingsSystem.__c__DisplayClass6_0.NativeMethodInfoPtr__OnUpdate_b__0_Internal_Void_ConversionSettingsAsset_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConversionSettingsSystem.__c__DisplayClass6_0>.NativeClassPtr, 100664901);
      }

      public __c__DisplayClass6_0(System.IntPtr pointer)
        : base(pointer)
      {
      }

      public unsafe ConversionSettingsAsset conversionSettingsAsset
      {
        get
        {
          System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(ConversionSettingsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_conversionSettingsAsset));
          return pointer == System.IntPtr.Zero ? (ConversionSettingsAsset) null : new ConversionSettingsAsset(pointer);
        }
        [param: In] set
        {
          System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
          IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(ConversionSettingsSystem.__c__DisplayClass6_0.NativeFieldInfoPtr_conversionSettingsAsset), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
        }
      }
    }
  }
}
