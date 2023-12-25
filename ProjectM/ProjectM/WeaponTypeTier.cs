// Decompiled with JetBrains decompiler
// Type: ProjectM.WeaponTypeTier
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
  public struct WeaponTypeTier
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_WeaponType;
    private static readonly System.IntPtr NativeFieldInfoPtr_Tier;
    private static readonly System.IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WeaponTypeTier_0;
    private static readonly System.IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;
    [FieldOffset(0)]
    public WeaponType WeaponType;
    [FieldOffset(4)]
    public int Tier;

    [CallerCount(2)]
    [CachedScanResults(RefRangeStart = 261548, RefRangeEnd = 261550, XrefRangeStart = 261548, XrefRangeEnd = 261550, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public virtual unsafe bool Equals(WeaponTypeTier other)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &other;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WeaponTypeTier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WeaponTypeTier_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    [CallerCount(0)]
    public override unsafe int GetHashCode()
    {
      System.IntPtr* numPtr = (System.IntPtr*) null;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(WeaponTypeTier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(int*) IL2CPP.il2cpp_object_unbox(num);
    }

    static WeaponTypeTier()
    {
      Il2CppClassPointerStore<WeaponTypeTier>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM", nameof (WeaponTypeTier));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WeaponTypeTier>.NativeClassPtr);
      WeaponTypeTier.NativeFieldInfoPtr_WeaponType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponTypeTier>.NativeClassPtr, nameof (WeaponType));
      WeaponTypeTier.NativeFieldInfoPtr_Tier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WeaponTypeTier>.NativeClassPtr, nameof (Tier));
      WeaponTypeTier.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_WeaponTypeTier_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponTypeTier>.NativeClassPtr, 100681132);
      WeaponTypeTier.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WeaponTypeTier>.NativeClassPtr, 100681133);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<WeaponTypeTier>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
