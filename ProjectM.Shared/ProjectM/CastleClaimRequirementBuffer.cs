// Decompiled with JetBrains decompiler
// Type: ProjectM.CastleClaimRequirementBuffer
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct CastleClaimRequirementBuffer
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Guid;
    private static readonly System.IntPtr NativeFieldInfoPtr_Stacks;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Guid_Private_Virtual_Final_New_get_PrefabGUID_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Amount_Private_Virtual_Final_New_get_Int32_0;
    [FieldOffset(0)]
    public PrefabGUID Guid;
    [FieldOffset(4)]
    public int Stacks;

    public virtual unsafe PrefabGUID ProjectM\u002EIRequirementBuffer\u002EGuid
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleClaimRequirementBuffer.NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Guid_Private_Virtual_Final_New_get_PrefabGUID_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(PrefabGUID*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    public virtual unsafe int ProjectM\u002EIRequirementBuffer\u002EAmount
    {
      [CallerCount(33), CachedScanResults(RefRangeStart = 107697, RefRangeEnd = 107730, XrefRangeStart = 107697, XrefRangeEnd = 107730, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(CastleClaimRequirementBuffer.NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Amount_Private_Virtual_Final_New_get_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(int*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static CastleClaimRequirementBuffer()
    {
      Il2CppClassPointerStore<CastleClaimRequirementBuffer>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (CastleClaimRequirementBuffer));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CastleClaimRequirementBuffer>.NativeClassPtr);
      CastleClaimRequirementBuffer.NativeFieldInfoPtr_Guid = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleClaimRequirementBuffer>.NativeClassPtr, nameof (Guid));
      CastleClaimRequirementBuffer.NativeFieldInfoPtr_Stacks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CastleClaimRequirementBuffer>.NativeClassPtr, nameof (Stacks));
      CastleClaimRequirementBuffer.NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Guid_Private_Virtual_Final_New_get_PrefabGUID_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleClaimRequirementBuffer>.NativeClassPtr, 100663990);
      CastleClaimRequirementBuffer.NativeMethodInfoPtr_ProjectM_IRequirementBuffer_get_Amount_Private_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CastleClaimRequirementBuffer>.NativeClassPtr, 100663991);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<CastleClaimRequirementBuffer>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
