// Decompiled with JetBrains decompiler
// Type: ProjectM.SpellSchoolTier
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM
{
  [StructLayout(LayoutKind.Explicit)]
  public struct SpellSchoolTier
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_SpellSchool;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tier;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpellSchoolTier_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public PrefabGUID SpellSchool;
    [FieldOffset(4)]
    public int Tier;

    [CallerCount(0)]
    [CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 1036757, XrefRangeEnd = 1036758, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(SpellSchoolTier other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellSchoolTier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpellSchoolTier_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(SpellSchoolTier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static SpellSchoolTier()
    {
      Il2CppClassPointerStore<SpellSchoolTier>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (SpellSchoolTier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpellSchoolTier>.NativeClassPtr);
      SpellSchoolTier.NativeFieldInfoPtr_SpellSchool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolTier>.NativeClassPtr, nameof (SpellSchool));
      SpellSchoolTier.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpellSchoolTier>.NativeClassPtr, nameof (Tier));
      SpellSchoolTier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_SpellSchoolTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolTier>.NativeClassPtr, 100681130);
      SpellSchoolTier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpellSchoolTier>.NativeClassPtr, 100681131);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpellSchoolTier>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
