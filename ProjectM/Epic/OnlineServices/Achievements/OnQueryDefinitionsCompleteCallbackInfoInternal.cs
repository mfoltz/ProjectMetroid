// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Achievements.OnQueryDefinitionsCompleteCallbackInfoInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Achievements
{
  [StructLayout(LayoutKind.Explicit)]
  public struct OnQueryDefinitionsCompleteCallbackInfoInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ResultCode;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ClientData;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientData_Public_get_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnQueryDefinitionsCompleteCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnQueryDefinitionsCompleteCallbackInfo_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnQueryDefinitionsCompleteCallbackInfo_0;
    [FieldOffset(0)]
    public Result m_ResultCode;
    [FieldOffset(8)]
    public System.IntPtr m_ClientData;

    public unsafe Result ResultCode
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(Result*) IL2CPP.il2cpp_object_unbox(num);
      }
      [CallerCount(20), CachedScanResults(RefRangeStart = 45001, RefRangeEnd = 45021, XrefRangeStart = 45001, XrefRangeEnd = 45021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = (System.IntPtr) &value;
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public unsafe Il2CppSystem.Object ClientData
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973778, XrefRangeEnd = 973782, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        System.IntPtr pointer = num;
        return pointer == System.IntPtr.Zero ? (Il2CppSystem.Object) null : new Il2CppSystem.Object(pointer);
      }
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973782, XrefRangeEnd = 973786, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    public virtual unsafe System.IntPtr ClientDataAddress
    {
      [CallerCount(1), CachedScanResults(RefRangeStart = 45474, RefRangeEnd = 45475, XrefRangeStart = 45474, XrefRangeEnd = 45475, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(System.IntPtr*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973786, XrefRangeEnd = 973790, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref OnQueryDefinitionsCompleteCallbackInfo other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnQueryDefinitionsCompleteCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973790, XrefRangeEnd = 973800, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(
      ref Il2CppSystem.Nullable<OnQueryDefinitionsCompleteCallbackInfo> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnQueryDefinitionsCompleteCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973800, XrefRangeEnd = 973804, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 973804, XrefRangeEnd = 973805, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Get(out OnQueryDefinitionsCompleteCallbackInfo output)
    {
      System.IntPtr* numPtr1 = stackalloc System.IntPtr[1];
      System.IntPtr* numPtr2 = numPtr1;
      System.IntPtr zero = System.IntPtr.Zero;
      System.IntPtr* numPtr3 = &zero;
      *numPtr2 = (System.IntPtr) numPtr3;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnQueryDefinitionsCompleteCallbackInfo_0, (System.IntPtr) ref this, (void**) numPtr1, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      ref OnQueryDefinitionsCompleteCallbackInfo local = ref output;
      System.IntPtr pointer = zero;
      OnQueryDefinitionsCompleteCallbackInfo completeCallbackInfo = pointer == System.IntPtr.Zero ? (OnQueryDefinitionsCompleteCallbackInfo) null : new OnQueryDefinitionsCompleteCallbackInfo(pointer);
      local = completeCallbackInfo;
    }

    static OnQueryDefinitionsCompleteCallbackInfoInternal()
    {
      Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Achievements", nameof (OnQueryDefinitionsCompleteCallbackInfoInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr);
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeFieldInfoPtr_m_ResultCode = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, nameof (m_ResultCode));
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeFieldInfoPtr_m_ClientData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, nameof (m_ClientData));
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ResultCode_Public_get_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, 100675109);
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_set_ResultCode_Public_set_Void_Result_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, 100675110);
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientData_Public_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, 100675111);
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_set_ClientData_Public_set_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, 100675112);
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_get_ClientDataAddress_Public_Virtual_Final_New_get_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, 100675113);
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_OnQueryDefinitionsCompleteCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, 100675114);
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_OnQueryDefinitionsCompleteCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, 100675115);
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, 100675116);
      OnQueryDefinitionsCompleteCallbackInfoInternal.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_byref_OnQueryDefinitionsCompleteCallbackInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, 100675117);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<OnQueryDefinitionsCompleteCallbackInfoInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
