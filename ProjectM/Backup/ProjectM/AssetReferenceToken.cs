// Decompiled with JetBrains decompiler
// Type: ProjectM.AssetReferenceToken
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using System.Runtime.InteropServices;
using Unity.Entities;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct AssetReferenceToken
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_AssetGuid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Token;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_InvalidToken_Public_Static_get_AssetReferenceToken_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AssetReferenceToken_AssetReferenceToken_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssetReferenceToken_AssetReferenceToken_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AssetReferenceToken_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public AssetGuid AssetGuid;
    [FieldOffset(16)]
    public ReferenceToken_Unboxed<Entity> Token;

    public static unsafe AssetReferenceToken InvalidToken
    {
      [CallerCount(3), CachedScanResults(RefRangeStart = 1073230, RefRangeEnd = 1073233, XrefRangeStart = 1073230, XrefRangeEnd = 1073230, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetReferenceToken.NativeMethodInfoPtr_get_InvalidToken_Public_Static_get_AssetReferenceToken_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(AssetReferenceToken*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1073234, RefRangeEnd = 1073237, XrefRangeStart = 1073233, XrefRangeEnd = 1073234, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator !=(AssetReferenceToken token1, AssetReferenceToken token2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &token1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &token2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetReferenceToken.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AssetReferenceToken_AssetReferenceToken_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073237, XrefRangeEnd = 1073238, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public static unsafe bool operator ==(AssetReferenceToken token1, AssetReferenceToken token2)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &token1;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &token2;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetReferenceToken.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssetReferenceToken_AssetReferenceToken_0, System.IntPtr.Zero, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(3)]
    [CachedScanResults(RefRangeStart = 1073240, RefRangeEnd = 1073243, XrefRangeStart = 1073238, XrefRangeEnd = 1073240, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(AssetReferenceToken other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetReferenceToken.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AssetReferenceToken_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073243, XrefRangeEnd = 1073247, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(Il2CppSystem.Object obj)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = IL2CPP.Il2CppObjectBaseToPtr((Il2CppObjectBase) obj);
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetReferenceToken.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1073247, XrefRangeEnd = 1073251, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(AssetReferenceToken.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static AssetReferenceToken()
    {
      Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (AssetReferenceToken));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr);
      AssetReferenceToken.NativeFieldInfoPtr_AssetGuid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr, nameof (AssetGuid));
      AssetReferenceToken.NativeFieldInfoPtr_Token = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr, nameof (Token));
      AssetReferenceToken.NativeMethodInfoPtr_get_InvalidToken_Public_Static_get_AssetReferenceToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr, 100684557);
      AssetReferenceToken.NativeMethodInfoPtr_op_Inequality_Public_Static_Boolean_AssetReferenceToken_AssetReferenceToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr, 100684558);
      AssetReferenceToken.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_AssetReferenceToken_AssetReferenceToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr, 100684559);
      AssetReferenceToken.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_AssetReferenceToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr, 100684560);
      AssetReferenceToken.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr, 100684561);
      AssetReferenceToken.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr, 100684562);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<AssetReferenceToken>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
