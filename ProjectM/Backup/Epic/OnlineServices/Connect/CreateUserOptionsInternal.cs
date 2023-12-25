// Decompiled with JetBrains decompiler
// Type: Epic.OnlineServices.Connect.CreateUserOptionsInternal
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;

#nullable disable
namespace Epic.OnlineServices.Connect
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CreateUserOptionsInternal
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ApiVersion;
    private static readonly System.IntPtr NativeFieldInfoPtr_m_ContinuanceToken;
    private static readonly System.IntPtr NativeMethodInfoPtr_set_ContinuanceToken_Public_set_Void_ContinuanceToken_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CreateUserOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CreateUserOptions_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;
    [FieldOffset(0)]
    public int m_ApiVersion;
    [FieldOffset(8)]
    public System.IntPtr m_ContinuanceToken;

    public unsafe ContinuanceToken ContinuanceToken
    {
      [CallerCount(0), CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965459, XrefRangeEnd = 965463, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] set
      {
        System.IntPtr* numPtr = stackalloc System.IntPtr[1];
        numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) value);
        System.IntPtr exc;
        IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_set_ContinuanceToken_Public_set_Void_ContinuanceToken_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
      }
    }

    [CallerCount(1)]
    [CachedScanResults(RefRangeStart = 965467, RefRangeEnd = 965468, XrefRangeStart = 965463, XrefRangeEnd = 965467, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref CreateUserOptions other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CreateUserOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965468, XrefRangeEnd = 965476, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Set(ref Il2CppSystem.Nullable<CreateUserOptions> other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtrNotNull((Il2CppObjectBase) other);
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CreateUserOptions_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 965476, XrefRangeEnd = 965480, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe void Dispose()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(CreateUserOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static CreateUserOptionsInternal()
    {
      Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "Epic.OnlineServices.Connect", nameof (CreateUserOptionsInternal));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr);
      CreateUserOptionsInternal.NativeFieldInfoPtr_m_ApiVersion = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, nameof (m_ApiVersion));
      CreateUserOptionsInternal.NativeFieldInfoPtr_m_ContinuanceToken = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, nameof (m_ContinuanceToken));
      CreateUserOptionsInternal.NativeMethodInfoPtr_set_ContinuanceToken_Public_set_Void_ContinuanceToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100672766);
      CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_CreateUserOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100672767);
      CreateUserOptionsInternal.NativeMethodInfoPtr_Set_Public_Virtual_Final_New_Void_byref_Nullable_1_CreateUserOptions_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100672768);
      CreateUserOptionsInternal.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, 100672769);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CreateUserOptionsInternal>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
