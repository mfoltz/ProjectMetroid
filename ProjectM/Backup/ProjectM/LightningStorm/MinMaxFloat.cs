// Decompiled with JetBrains decompiler
// Type: ProjectM.LightningStorm.MinMaxFloat
// Assembly: ProjectM, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 83E42B70-D81B-4F1F-9FB5-6B5ABD5FF9FC
// Assembly location: C:\Users\mitch\.nuget\packages\vrising.unhollowed.client\0.6.5.57575090\lib\net6.0\ProjectM.dll

using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using System;
using System.Runtime.InteropServices;

#nullable disable
namespace ProjectM.LightningStorm
{
  [Serializable]
  [StructLayout(LayoutKind.Explicit)]
  public struct MinMaxFloat
  {
    private static readonly System.IntPtr NativeFieldInfoPtr_Min;
    private static readonly System.IntPtr NativeFieldInfoPtr_Max;
    private static readonly System.IntPtr NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0;
    [FieldOffset(0)]
    public float Min;
    [FieldOffset(4)]
    public float Max;

    [CallerCount(20)]
    [CachedScanResults(RefRangeStart = 214001, RefRangeEnd = 214021, XrefRangeStart = 214001, XrefRangeEnd = 214021, MetadataInitTokenRva = 0, MetadataInitFlagRva = 0)]
    public unsafe MinMaxFloat(float min, float max)
    {
      System.IntPtr* numPtr = stackalloc System.IntPtr[2];
      numPtr[0] = (System.IntPtr) &min;
      *(System.IntPtr*) ((System.IntPtr) numPtr + checked (new System.IntPtr(1) * sizeof (System.IntPtr))) = (System.IntPtr) &max;
      System.IntPtr exc;
      IL2CPP.il2cpp_runtime_invoke(MinMaxFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0, (System.IntPtr) ref this, (void**) numPtr, ref exc);
      Il2CppException.RaiseExceptionIfNecessary(exc);
    }

    static MinMaxFloat()
    {
      Il2CppClassPointerStore<MinMaxFloat>.NativeClassPtr = IL2CPP.GetIl2CppClass("ProjectM.dll", "ProjectM.LightningStorm", nameof (MinMaxFloat));
      IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MinMaxFloat>.NativeClassPtr);
      MinMaxFloat.NativeFieldInfoPtr_Min = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxFloat>.NativeClassPtr, nameof (Min));
      MinMaxFloat.NativeFieldInfoPtr_Max = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MinMaxFloat>.NativeClassPtr, nameof (Max));
      MinMaxFloat.NativeMethodInfoPtr__ctor_Public_Void_Single_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MinMaxFloat>.NativeClassPtr, 100688495);
    }

    public Il2CppSystem.Object BoxIl2CppObject()
    {
      return new Il2CppSystem.Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<MinMaxFloat>.NativeClassPtr, (System.IntPtr) ref this));
    }
  }
}
