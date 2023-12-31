// Decompiled with JetBrains decompiler
// Type: ProjectM.Shared.StatModValue
// Assembly: ProjectM.Shared, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: CF03A298-FF93-4294-AFD6-565AD334A53C
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.Shared.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.Shared
{
  [StructLayout(LayoutKind.Explicit)]
  public struct StatModValue
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Scale;
    private static readonly System.IntPtr NativeFieldInfoPtr_Offset;
    private static readonly System.IntPtr NativeFieldInfoPtr_Curve;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatType;
    private static readonly System.IntPtr NativeFieldInfoPtr_StatModificationType;
    private static readonly System.IntPtr NativeMethodInfoPtr_Evaluate_Public_Single_byref_CurveCollection_Single_0;
    [FieldOffset(0)]
    public float Scale;
    [FieldOffset(4)]
    public float Offset;
    [FieldOffset(8)]
    public CurveReference Curve;
    [FieldOffset(16)]
    public UnitStatType StatType;
    [FieldOffset(17)]
    public ModificationType StatModificationType;

    [CallerCount(12)]
    [CachedScanResults(RefRangeStart = 798575, RefRangeEnd = 798587, XrefRangeStart = 798575, XrefRangeEnd = 798587, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe float Evaluate([In] ref CurveCollection collection, float power)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) ref collection;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &power;
      System.IntPtr exc;
      System.IntPtr num = IL2CPP.il2cpp_runtime_invoke(StatModValue.NativeMethodInfoPtr_Evaluate_Public_Single_byref_CurveCollection_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
      return *(float*) IL2CPP.il2cpp_object_unbox(num);
    }

    static StatModValue()
    {
      Il2CppClassPointerStore<StatModValue>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.Shared.dll", "ProjectM.Shared", nameof (StatModValue));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<StatModValue>.NativeClassPtr);
      StatModValue.NativeFieldInfoPtr_Scale = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatModValue>.NativeClassPtr, nameof (Scale));
      StatModValue.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatModValue>.NativeClassPtr, nameof (Offset));
      StatModValue.NativeFieldInfoPtr_Curve = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatModValue>.NativeClassPtr, nameof (Curve));
      StatModValue.NativeFieldInfoPtr_StatType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatModValue>.NativeClassPtr, nameof (StatType));
      StatModValue.NativeFieldInfoPtr_StatModificationType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<StatModValue>.NativeClassPtr, nameof (StatModificationType));
      StatModValue.NativeMethodInfoPtr_Evaluate_Public_Single_byref_CurveCollection_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<StatModValue>.NativeClassPtr, 100670423);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<StatModValue>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
