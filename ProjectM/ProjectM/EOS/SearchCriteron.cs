// Decompiled with JetBrains decompiler
// Type: ProjectM.EOS.SearchCriteron
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Epic.OnlineServices;
using Epic.OnlineServices.Sessions;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.EOS
{
  public sealed class SearchCriteron : Il2CppSystem.ValueType
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_comparisonOperator;
    private static readonly System.IntPtr NativeFieldInfoPtr_attribute;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComparisonOp_SessionAttribute_0;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_ComparisonOp_String_AttributeDataValue_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ToSessionSearchSetParameterOptions_Public_SessionSearchSetParameterOptions_0;

    [CallerCount(17)]
    [CachedScanResults(RefRangeStart = 1123775, RefRangeEnd = 1123792, XrefRangeStart = 1123774, XrefRangeEnd = 1123775, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SearchCriteron(ComparisonOp comparisonOperator, SessionAttribute attribute)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &comparisonOperator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) attribute));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SearchCriteron.NativeMethodInfoPtr__ctor_Public_Void_ComparisonOp_SessionAttribute_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1123794, RefRangeEnd = 1123795, XrefRangeStart = 1123792, XrefRangeEnd = 1123794, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SearchCriteron(
      ComparisonOp comparisonOperator,
      string key,
      AttributeDataValue value)
      : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr))
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[3];
      numPtr[0] = (System.IntPtr) &comparisonOperator;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = IL2CPP.ManagedStringToIl2Cpp(key);
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(2) * sizeof (System.IntPtr))) = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) value));
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(SearchCriteron.NativeMethodInfoPtr__ctor_Public_Void_ComparisonOp_String_AttributeDataValue_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 1123800, RefRangeEnd = 1123801, XrefRangeStart = 1123795, XrefRangeEnd = 1123800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe SessionSearchSetParameterOptions ToSessionSearchSetParameterOptions()
    {
      IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this);
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SearchCriteron.NativeMethodInfoPtr_ToSessionSearchSetParameterOptions_Public_SessionSearchSetParameterOptions_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this)), (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return new SessionSearchSetParameterOptions(pointer);
    }

    static SearchCriteron()
    {
      Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.EOS", nameof (SearchCriteron));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr);
      SearchCriteron.NativeFieldInfoPtr_comparisonOperator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr, nameof (comparisonOperator));
      SearchCriteron.NativeFieldInfoPtr_attribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr, nameof (attribute));
      SearchCriteron.NativeMethodInfoPtr__ctor_Public_Void_ComparisonOp_SessionAttribute_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr, 100689167);
      SearchCriteron.NativeMethodInfoPtr__ctor_Public_Void_ComparisonOp_String_AttributeDataValue_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr, 100689168);
      SearchCriteron.NativeMethodInfoPtr_ToSessionSearchSetParameterOptions_Public_SessionSearchSetParameterOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr, 100689169);
    }

    public SearchCriteron(System.IntPtr pointer)
      : base(pointer)
    {
    }

    public SearchCriteron()
    {
      // ISSUE: cast to a reference type
      // ISSUE: untyped stack allocation
      System.IntPtr data = __untypedstackalloc((System.IntPtr) (uint) IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      // ISSUE: explicit constructor call
      base.\u002Ector(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SearchCriteron>.NativeClassPtr, data));
    }

    public unsafe ComparisonOp comparisonOperator
    {
      get
      {
        return *(ComparisonOp*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchCriteron.NativeFieldInfoPtr_comparisonOperator));
      }
      [param: In] set
      {
        *(ComparisonOp*) (IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchCriteron.NativeFieldInfoPtr_comparisonOperator)) = value;
      }
    }

    public SessionAttribute attribute
    {
      get
      {
        System.IntPtr data = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchCriteron.NativeFieldInfoPtr_attribute);
        return new SessionAttribute(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, data));
      }
      [param: In] set
      {
        __memcpy(IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) this) + (int) IL2CPP.il2cpp_field_get_offset(SearchCriteron.NativeFieldInfoPtr_attribute), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<SessionAttribute>.NativeClassPtr, (uint&) System.IntPtr.Zero));
      }
    }
  }
}
