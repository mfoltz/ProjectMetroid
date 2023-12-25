// Decompiled with JetBrains decompiler
// Type: ProjectM.TextFilterer
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using ProjectM.Auth;
using Steamworks;
using System.Runtime.InteropServices;
using Unity.Entities;
using Unity.Profiling;

#nullable disable
namespace ProjectM
{
  public sealed class TextFilterer : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr__FilterTextMarker;
    private static readonly System.IntPtr NativeFieldInfoPtr__SteamPlatformSystem;
    private static readonly System.IntPtr NativeFieldInfoPtr__UseSteamFilter;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_TextFilterer_SystemBase_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Create_Public_Static_TextFilterer_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterText_Public_String_String_CSteamID_UInt32_ETextFilteringContext_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_FilterText_Public_String_String_UInt32_0;

    [CallerCount(7)]
    [CachedScanResults(RefRangeStart = 1073953, RefRangeEnd = 1073960, XrefRangeStart = 1073947, XrefRangeEnd = 1073953, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TextFilterer Create(SystemBase systemBase)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) systemBase);
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TextFilterer.NativeMethodInfoPtr_Create_Public_Static_TextFilterer_SystemBase_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new TextFilterer(pointer);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1073963, RefRangeEnd = 1073964, XrefRangeStart = 1073960, XrefRangeEnd = 1073963, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe TextFilterer Create()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(TextFilterer.NativeMethodInfoPtr_Create_Public_Static_TextFilterer_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new TextFilterer(pointer);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073964, XrefRangeEnd = 1073977, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string FilterText(
      string input,
      CSteamID fromUser,
      uint textSize,
      ETextFilteringContext context)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[4];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &fromUser;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = (System.IntPtr) &textSize;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(3) * sizeof (System.IntPtr))) = (System.IntPtr) &context;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TextFilterer.NativeMethodInfoPtr_FilterText_Public_String_String_CSteamID_UInt32_ETextFilteringContext_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 1073990, RefRangeEnd = 1074002, XrefRangeStart = 1073977, XrefRangeEnd = 1073990, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe string FilterText(string input, uint textSize = 512)
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = IL2CPP.ManagedStringToIl2Cpp(input);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &textSize;
      System.IntPtr exc;
      System.IntPtr il2CppString = IL2CPP.il2cpp_runtime_invoke(TextFilterer.NativeMethodInfoPtr_FilterText_Public_String_String_UInt32_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return IL2CPP.Il2CppStringToManaged(il2CppString);
    }

    static TextFilterer()
    {
      Il2CppClassPointerStore<TextFilterer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (TextFilterer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr);
      TextFilterer.NativeFieldInfoPtr__FilterTextMarker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, nameof (_FilterTextMarker));
      TextFilterer.NativeFieldInfoPtr__SteamPlatformSystem = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, nameof (_SteamPlatformSystem));
      TextFilterer.NativeFieldInfoPtr__UseSteamFilter = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, nameof (_UseSteamFilter));
      TextFilterer.NativeMethodInfoPtr_Create_Public_Static_TextFilterer_SystemBase_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, 100684620);
      TextFilterer.NativeMethodInfoPtr_Create_Public_Static_TextFilterer_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, 100684621);
      TextFilterer.NativeMethodInfoPtr_FilterText_Public_String_String_CSteamID_UInt32_ETextFilteringContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, 100684622);
      TextFilterer.NativeMethodInfoPtr_FilterText_Public_String_String_UInt32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, 100684623);
    }

    public TextFilterer(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public TextFilterer()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<TextFilterer>.NativeClassPtr, data));
    }

    public static unsafe ProfilerMarker _FilterTextMarker
    {
      get
      {
        ProfilerMarker filterTextMarker;
        IL2CPP.il2cpp_field_static_get_value(TextFilterer.NativeFieldInfoPtr__FilterTextMarker, (void*) &filterTextMarker);
        return filterTextMarker;
      }
      [param: In] set
      {
        IL2CPP.il2cpp_field_static_set_value(TextFilterer.NativeFieldInfoPtr__FilterTextMarker, (void*) &value);
      }
    }

    public unsafe SteamPlatformSystem _SteamPlatformSystem
    {
      get
      {
        System.IntPtr pointer = *(System.IntPtr*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextFilterer.NativeFieldInfoPtr__SteamPlatformSystem));
        return pointer == System.IntPtr.Zero ? (SteamPlatformSystem) null : new SteamPlatformSystem(pointer);
      }
      [param: In] set
      {
        System.IntPtr ptrNotNull = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
        IL2CPP.il2cpp_gc_wbarrier_set_field(ptrNotNull, ptrNotNull + (int) IL2CPP.il2cpp_field_get_offset(TextFilterer.NativeFieldInfoPtr__SteamPlatformSystem), IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value));
      }
    }

    public unsafe bool _UseSteamFilter
    {
      get
      {
        return *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextFilterer.NativeFieldInfoPtr__UseSteamFilter));
      }
      [param: In] set
      {
        *(bool*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(TextFilterer.NativeFieldInfoPtr__UseSteamFilter)) = value;
      }
    }
  }
}
