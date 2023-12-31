// Decompiled with JetBrains decompiler
// Type: ProjectM.DealDamageParameters
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
  public struct DealDamageParameters
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_MaterialModifiers;
    private static readonly System.IntPtr NativeFieldInfoPtr_MainFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_ResourceModifier;
    private static readonly System.IntPtr NativeFieldInfoPtr_StaggerFactor;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawDamageValue;
    private static readonly System.IntPtr NativeFieldInfoPtr_RawDamagePercent;
    private static readonly System.IntPtr NativeFieldInfoPtr_DealDamageFlags;
    private static readonly System.IntPtr NativeFieldInfoPtr_MainType;
    private static readonly System.IntPtr NativeMethodInfoPtr_HasFlag_Public_Boolean_DealDamageFlag_0;
    [FieldOffset(0)]
    public EntityTypeModifiers MaterialModifiers;
    [FieldOffset(84)]
    public float MainFactor;
    [FieldOffset(88)]
    public float ResourceModifier;
    [FieldOffset(92)]
    public float StaggerFactor;
    [FieldOffset(96)]
    public float RawDamageValue;
    [FieldOffset(100)]
    public float RawDamagePercent;
    [FieldOffset(104)]
    public int DealDamageFlags;
    [FieldOffset(108)]
    public MainDamageType MainType;

    [CallerCount(0)]
    public unsafe bool HasFlag(DealDamageFlag flag)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[1];
      numPtr[0] = (System.IntPtr) &flag;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(DealDamageParameters.NativeMethodInfoPtr_HasFlag_Public_Boolean_DealDamageFlag_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(bool*) IL2CPP.il2cpp_object_unbox(num);
    }

    static DealDamageParameters()
    {
      Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM", nameof (DealDamageParameters));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr);
      DealDamageParameters.NativeFieldInfoPtr_MaterialModifiers = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr, nameof (MaterialModifiers));
      DealDamageParameters.NativeFieldInfoPtr_MainFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr, nameof (MainFactor));
      DealDamageParameters.NativeFieldInfoPtr_ResourceModifier = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr, nameof (ResourceModifier));
      DealDamageParameters.NativeFieldInfoPtr_StaggerFactor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr, nameof (StaggerFactor));
      DealDamageParameters.NativeFieldInfoPtr_RawDamageValue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr, nameof (RawDamageValue));
      DealDamageParameters.NativeFieldInfoPtr_RawDamagePercent = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr, nameof (RawDamagePercent));
      DealDamageParameters.NativeFieldInfoPtr_DealDamageFlags = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr, nameof (DealDamageFlags));
      DealDamageParameters.NativeFieldInfoPtr_MainType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr, nameof (MainType));
      DealDamageParameters.NativeMethodInfoPtr_HasFlag_Public_Boolean_DealDamageFlag_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr, 100665114);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<DealDamageParameters>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
