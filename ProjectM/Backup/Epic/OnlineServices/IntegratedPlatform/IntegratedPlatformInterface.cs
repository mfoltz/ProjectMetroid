// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.IntegratedPlatform.IntegratedPlatformInterface
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.IntegratedPlatform
{
  public sealed class IntegratedPlatformInterface : Il2CppSystem.Object
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_CreateintegratedplatformoptionscontainerApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_IptSteam;
    private static readonly System.IntPtr NativeFieldInfoPtr_OptionsApiLatest;
    private static readonly System.IntPtr NativeFieldInfoPtr_SteamOptionsApiLatest;
    private static readonly System.IntPtr NativeMethodInfoPtr_CreateIntegratedPlatformOptionsContainer_Public_Static_Result_byref_CreateIntegratedPlatformOptionsContainerOptions_byref_IntegratedPlatformOptionsContainer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 960249, XrefRangeEnd = 960261, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe Result CreateIntegratedPlatformOptionsContainer(
      ref CreateIntegratedPlatformOptionsContainerOptions options,
      out IntegratedPlatformOptionsContainer outIntegratedPlatformOptionsContainerHandle)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[2];
      numPtr1[0] = (System.IntPtr) ref options;
      System.IntPtr num1 = (System.IntPtr) numPtr1 + checked (new System.IntPtr(1) * sizeof (System.IntPtr));
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr2 = &zero;
      *(System.IntPtr*) num1 = (System.IntPtr) numPtr2;
      System.IntPtr exc;
      System.IntPtr num2 = IL2CPP.il2cpp_runtime_invoke(IntegratedPlatformInterface.NativeMethodInfoPtr_CreateIntegratedPlatformOptionsContainer_Public_Static_Result_byref_CreateIntegratedPlatformOptionsContainerOptions_byref_IntegratedPlatformOptionsContainer_0, System.IntPtr.Zero, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref IntegratedPlatformOptionsContainer local = ref outIntegratedPlatformOptionsContainerHandle;
      System.IntPtr pointer = zero;
      IntegratedPlatformOptionsContainer optionsContainer = pointer == System.IntPtr.Zero ? (IntegratedPlatformOptionsContainer) null : new IntegratedPlatformOptionsContainer(pointer);
      local = optionsContainer;
      return *(Result*) IL2CPP.il2cpp_object_unbox(num2);
    }

    [CallerCount(3875)]
    [CachedScanResults(RefRangeStart = 16608, RefRangeEnd = 20483, XrefRangeStart = 16608, XrefRangeEnd = 20483, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe IntegratedPlatformInterface()
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegratedPlatformInterface>.NativeClassPtr))
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(IntegratedPlatformInterface.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static IntegratedPlatformInterface()
    {
      Il2CppClassPointerStore<IntegratedPlatformInterface>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.IntegratedPlatform", nameof (IntegratedPlatformInterface));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedPlatformInterface>.NativeClassPtr);
      IntegratedPlatformInterface.NativeFieldInfoPtr_CreateintegratedplatformoptionscontainerApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedPlatformInterface>.NativeClassPtr, nameof (CreateintegratedplatformoptionscontainerApiLatest));
      IntegratedPlatformInterface.NativeFieldInfoPtr_IptSteam = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedPlatformInterface>.NativeClassPtr, nameof (IptSteam));
      IntegratedPlatformInterface.NativeFieldInfoPtr_OptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedPlatformInterface>.NativeClassPtr, nameof (OptionsApiLatest));
      IntegratedPlatformInterface.NativeFieldInfoPtr_SteamOptionsApiLatest = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedPlatformInterface>.NativeClassPtr, nameof (SteamOptionsApiLatest));
      IntegratedPlatformInterface.NativeMethodInfoPtr_CreateIntegratedPlatformOptionsContainer_Public_Static_Result_byref_CreateIntegratedPlatformOptionsContainerOptions_byref_IntegratedPlatformOptionsContainer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedPlatformInterface>.NativeClassPtr, 100671393);
      IntegratedPlatformInterface.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedPlatformInterface>.NativeClassPtr, 100671394);
    }

    public IntegratedPlatformInterface(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public static unsafe int CreateintegratedplatformoptionscontainerApiLatest
    {
      get
      {
        int createintegratedplatformoptionscontainerApiLatest;
        IL2CPP.il2cpp_field_static_get_value(IntegratedPlatformInterface.NativeFieldInfoPtr_CreateintegratedplatformoptionscontainerApiLatest, (void*) &createintegratedplatformoptionscontainerApiLatest);
        return createintegratedplatformoptionscontainerApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IntegratedPlatformInterface.NativeFieldInfoPtr_CreateintegratedplatformoptionscontainerApiLatest, (void*) &value);
      }
    }

    public static unsafe Epic.OnlineServices.Utf8String IptSteam
    {
      get
      {
        System.IntPtr num;
        IL2CPP.il2cpp_field_static_get_value(IntegratedPlatformInterface.NativeFieldInfoPtr_IptSteam, (void*) &num);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Epic.OnlineServices.Utf8String) null : new Epic.OnlineServices.Utf8String(pointer);
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IntegratedPlatformInterface.NativeFieldInfoPtr_IptSteam, (void*) IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public static unsafe int OptionsApiLatest
    {
      get
      {
        int optionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(IntegratedPlatformInterface.NativeFieldInfoPtr_OptionsApiLatest, (void*) &optionsApiLatest);
        return optionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IntegratedPlatformInterface.NativeFieldInfoPtr_OptionsApiLatest, (void*) &value);
      }
    }

    public static unsafe int SteamOptionsApiLatest
    {
      get
      {
        int optionsApiLatest;
        IL2CPP.il2cpp_field_static_get_value(IntegratedPlatformInterface.NativeFieldInfoPtr_SteamOptionsApiLatest, (void*) &optionsApiLatest);
        return optionsApiLatest;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(IntegratedPlatformInterface.NativeFieldInfoPtr_SteamOptionsApiLatest, (void*) &value);
      }
    }
  }
}
