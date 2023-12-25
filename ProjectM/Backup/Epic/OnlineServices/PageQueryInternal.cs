// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.PageQueryInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices
{
  [StructLayout(LayoutKind.Explicit)]
  public struct PageQueryInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_StartIndex;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_MaxCount;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_MaxCount_Public_get_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_MaxCount_Public_set_Void_Int32_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PageQuery_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PageQuery_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PageQuery_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(4)]
    public int m_StartIndex;
    [FieldOffset(8)]
    public int m_MaxCount;

    public unsafe int StartIndex
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PageQueryInternal.NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(14), CachedScanResults(RefRangeStart = 204767, RefRangeEnd = 204781, XrefRangeStart = 204767, XrefRangeEnd = 204781, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PageQueryInternal.NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe int MaxCount
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 40848, RefRangeEnd = 40881, XrefRangeStart = 40848, XrefRangeEnd = 40881, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(PageQueryInternal.NativeMethodInfoPtr_get_MaxCount_Public_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(11), CachedScanResults(RefRangeStart = 204781, RefRangeEnd = 204792, XrefRangeStart = 204781, XrefRangeEnd = 204792, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(PageQueryInternal.NativeMethodInfoPtr_set_MaxCount_Public_set_Void_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(0)]
    public virtual unsafe void Set(ref PageQuery other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PageQueryInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PageQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 936363, XrefRangeEnd = 936369, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Nullable_Unboxed<PageQuery> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref other;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PageQueryInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PageQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(10560)]
    [CachedScanResults(RefRangeStart = 24, RefRangeEnd = 10584, XrefRangeStart = 24, XrefRangeEnd = 10584, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PageQueryInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    public virtual unsafe void Get(out PageQuery output)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) ref output;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(PageQueryInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PageQuery_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static PageQueryInternal()
    {
      Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices", nameof (PageQueryInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr);
      PageQueryInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, nameof (m_ApiVersion));
      PageQueryInternal.NativeFieldInfoPtr_m_StartIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, nameof (m_StartIndex));
      PageQueryInternal.NativeFieldInfoPtr_m_MaxCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, nameof (m_MaxCount));
      PageQueryInternal.NativeMethodInfoPtr_get_StartIndex_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, 100664840);
      PageQueryInternal.NativeMethodInfoPtr_set_StartIndex_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, 100664841);
      PageQueryInternal.NativeMethodInfoPtr_get_MaxCount_Public_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, 100664842);
      PageQueryInternal.NativeMethodInfoPtr_set_MaxCount_Public_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, 100664843);
      PageQueryInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_PageQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, 100664844);
      PageQueryInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_Unboxed_1_PageQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, 100664845);
      PageQueryInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, 100664846);
      PageQueryInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_PageQuery_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, 100664847);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PageQueryInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
