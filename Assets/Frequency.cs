using UnityEngine;
using System.Collections;

public class Frequency : MonoBehaviour {

	float[] _lastRMS;
	
	void OnAudioFilterRead( float[] data, int numChannels )
	{
		int i;
		float rms;
		
		if( _lastRMS == null )
			_lastRMS = new float[ numChannels ];
		
		for( i = 0; i < numChannels; i++ )
		{
			rms = ComputeSumOfSquares( data, numChannels, i );
			rms = Mathf.Sqrt( rms ) / ( data.Length / numChannels );
			_lastRMS[ i ] = rms;
		}
	}
	
	float ComputeSumOfSquares( float[] data, int stride, int offset )
	{
		int i;
		float ret=0.0F;
		for( i =offset; i < data.Length; i += stride )
		{
			ret += data[ i ] * data[ i ];
		}
		return ret;
	}
	
	void Update() {

transform.localPosition = new Vector3( _lastRMS[ 0 ], _lastRMS[ 1 ], 0f );

	}
}
	