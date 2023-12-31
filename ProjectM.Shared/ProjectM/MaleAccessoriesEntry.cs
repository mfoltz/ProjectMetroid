// Decompiled with JetBrains decompiler
// Type: ProjectM.MaleAccessoriesEntry
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using ProjectM.Shared;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct MaleAccessoriesEntry
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Requirement;
    private static readonly System.IntPtr NativeMethodInfoPtr_get_RequirementRO_Public_Virtual_Final_New_get_UserContentFlags_0;
    [FieldOffset(0)]
    public UserContentFlags Requirement;

    public virtual unsafe UserContentFlags RequirementRO
    {
      [CallerCount(409), CachedScanResults(RefRangeStart = 45065, RefRangeEnd = 45474, XrefRangeStart = 45065, XrefRangeEnd = 45474, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)] get
      {
        System.IntPtr* numPtr = (System.IntPtr*) null;
        System.IntPtr exc;
        System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(MaleAccessoriesEntry.NativeMethodInfoPtr_get_RequirementRO_Public_Virtual_Final_New_get_UserContentFlags_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
        Il2CppException.RaiseExceptionIfNecessary(exc);
        return *(UserContentFlags*) IL2CPP.il2cpp_object_unbox(num);
      }
    }

    static MaleAccessoriesEntry()
    {
      Il2CppClassPointerStore<MaleAccessoriesEntry>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (MaleAccessoriesEntry));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MaleAccessoriesEntry>.NativeClassPtr);
      MaleAccessoriesEntry.NativeFieldInfoPtr_Requirement = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MaleAccessoriesEntry>.NativeClassPtr, nameof (Requirement));
      MaleAccessoriesEntry.NativeMethodInfoPtr_get_RequirementRO_Public_Virtual_Final_New_get_UserContentFlags_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MaleAccessoriesEntry>.NativeClassPtr, 100663850);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MaleAccessoriesEntry>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
